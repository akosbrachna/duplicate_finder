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

namespace duplicate_finder.App
{
    public partial class Result_Form : Form
    {
        public Result_Form(Config config)
        {
            InitializeComponent();
            listView_result.Columns.Add("Files").Width = 300;
            listView_result.Columns.Add("Match");
            listView_result.Columns.Add("File size");
            listView_result.Columns.Add("Proximity %").Width = 120;
            total_files.Text = "Number of files: " + config.total_files.ToString();
            total_size.Text = "Total size: " + config.total_size.ToString() + " MB";
        }

        public void show_result(List<myList> result_array)
        {
            foreach (myList item in result_array)
            {
                ListViewItem lvi = new ListViewItem(new string[] { item.name, item.duplicate, item.file_size.ToString(), item.proximity.ToString() });
                //lvi.ToolTipText = item.name;
                listView_result.Items.Add(lvi);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = System.Diagnostics.Process.Start(listView_result.SelectedItems[0].SubItems[0].Text);
        }

        private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(listView_result.SelectedItems[0].SubItems[0].Text);
            Process.Start(path);
        }

        private void filePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File_Info.ShowFileProperties(@listView_result.SelectedItems[0].SubItems[0].Text);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                         "Confirm File Delete!",
                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete(listView_result.SelectedItems[0].SubItems[0].Text);
                    listView_result.SelectedItems[0].Remove();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        private void listView_result_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process proc = System.Diagnostics.Process.Start(listView_result.SelectedItems[0].SubItems[0].Text);
        }
    }
}
