using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace duplicate_finder.App
{
    public class Processor : IProcessor
    {
        // Config data
        protected int min_file_size = 50000;
        protected double file_size_match_settings = 0.85;
        protected double content_match_settings = 0.85;
        protected float number_of_samples = 5;
        protected int size_of_sample = 200;

        // Output result data
        protected List<myList> result_array = new List<myList>();
        //input data
        public List<Input> all_files;
        // Output result form
        protected Result_Form form;
        protected BackgroundWorker backgroundWorker1 = new BackgroundWorker();

        public void Start(Config config, List<Input> input)
        {
            all_files = input;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            min_file_size = config.min_file_size;
            file_size_match_settings = config.file_size_match_settings;
            content_match_settings = config.content_match_settings;
            form = new Result_Form(config);
            form.Show();
            backgroundWorker1.RunWorkerAsync();
        }

        protected byte[] copy_file_content(string file)
        {
            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            byte[] full_sample = new byte[size_of_sample * (int)number_of_samples];

            for (int i = 0; i < number_of_samples; i++)
            {
                fs.Seek((long)((float)fs.Length * ((double)i / number_of_samples)), SeekOrigin.Begin);
                fs.Read(full_sample, i * size_of_sample, size_of_sample);
            }
            fs.Close();
            return full_sample;
        }

        protected double match_proximity = 0;

        protected virtual bool compare_files(byte[] file_origin, byte[] file_current) 
        {
            return true;
        }

        public int count = 0;
        public int result_array_counter;

        protected void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool match;
            long current_file_size, file_size;
            double size_match;
            byte[] current_file_content, origin_file_content;
            List<myList> result_files = new List<myList>();
            bool origin;
            int group = 0;
            bool same_group;

            result_array_counter = 0;

            for (int i = 0; i < all_files.Count; i++)
            {
                count = i;
                current_file_size = new FileInfo(all_files[i].filename).Length;
                if (current_file_size < min_file_size) continue;

                origin_file_content = copy_file_content(all_files[i].filename);
                origin = true;

                for (int j = i + 1; j < all_files.Count; j++)
                {
                    same_group = false;
                    file_size = new FileInfo(all_files[j].filename).Length;
                    if (file_size < current_file_size)
                        size_match = (double)file_size / (double)current_file_size;
                    else size_match = (double)current_file_size / (double)file_size;
                    if (size_match < file_size_match_settings) continue;

                    if (all_files[i].group.Count != 0 && all_files[j].group.Count != 0)
                    {
                        foreach (int group1 in all_files[i].group)
                        {
                            foreach (int group2 in all_files[j].group)
                            {
                                if (group1 == group2)
                                {
                                    same_group = true;
                                    break;
                                }
                            }
                            if (same_group) break;
                        }
                        if (same_group)
                        {
                            continue;
                        }
                    }
                    current_file_content = copy_file_content(all_files[j].filename);

                    match = compare_files(origin_file_content, current_file_content);

                    if (match)
                    {
                        if (origin)
                        {
                            group++;
                            all_files[i].group.Add(group);
                            result_array.Add(new myList(all_files[i].filename, "origin", current_file_size, 100.0));
                        }
                        all_files[j].group.Add(group);
                        result_array.Add(new myList(all_files[j].filename, "duplicate", file_size, match_proximity * 100));
                        origin = false;
                    }
                }
                backgroundWorker1.ReportProgress((i * 100) / all_files.Count);
            }
        }

        protected void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            form.progressBar1.Value = e.ProgressPercentage;
            form.progress_text.Text = "Progress: " + e.ProgressPercentage.ToString() + "%   -  " + count.ToString() + "/" + all_files.Count.ToString();
            form.lbl_file_checked.Text = all_files[count].filename;
            form.result_text.Text = "Result: " + result_array.Count.ToString() + " files found";
        }

        protected void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            form.lbl_file_checked.Text = "";
            form.progressBar1.Value = 100;
            form.progress_text.Text = "Progress: 100%";
            form.result_text.Text = "Result: " + result_array.Count.ToString() + " files found";
            form.show_result(result_array);
        }
    }
}
