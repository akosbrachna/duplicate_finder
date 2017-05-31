using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;

namespace duplicate_finder.App
{
    public partial class File_manager : Form
    {
        public File_manager()
        {
            InitializeComponent();
        }

        public List<Input> all_files = new List<Input>();
        public Config config = new Config();
        private IProcessor processor;

        private void btn_start_work_Click(object sender, EventArgs e)
        {
            if (all_files.Count == 0)
            {
                MessageBox.Show("No files found. Please select folders that contain files.");
                return;
            }
            foreach (var file in all_files)
            {
                file.group = new List<int>();
            }
            select_method();
            processor.Start(config, all_files);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process proc = Process.Start(listBox1.SelectedItem.ToString());
        }

        private String last_path=@"C:\";
        private long files_size = 0;

        private void select_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = last_path;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                last_path = fbd.SelectedPath.ToString();
                add_directory(last_path);
            }

        }

        private void add_directory(string dir)
        {
            if (ListBox.NoMatches != listBox1.FindStringExact(dir))
            {
                return;
            }
            listBox1.Items.Add(dir);

            string[] files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                files_size += new FileInfo(file).Length;
                all_files.Add(new Input(file));
            }
            config.total_files = all_files.Count;
            config.total_size = Math.Round((double)files_size/1024.0/1024.0, 2);
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            all_files = new List<Input>();
            files_size = 0;
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] directories = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string dir in directories)
            {
                add_directory(dir);
            }
        }

        private void textBox_min_file_size_TextChanged(object sender, EventArgs e)
        {
            try
            {
                config.min_file_size = int.Parse(textBox_min_file_size.Text);
            }
            catch (Exception ex) {  }
        }

        private void file_size_match_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                config.file_size_match_settings = ((double)file_size_match.Value) / 100;
            }
            catch (Exception ex) { }
        }

        private void content_match_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                config.content_match_settings = ((double)content_match.Value) / 100;
            }
            catch (Exception ex) { }
        }

        private void select_method()
        {
            switch (list_methods.Text)
            {
                case "Statistical":
                    processor = new Processor_Statistical();
                    break;
                case "Simple":
                    processor = new Processor_Simple();
                    break;
                default: processor = new Processor_Statistical();
                    break;
            }
        }
    }
}
