namespace duplicate_finder.App
{
    partial class Result_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result_Form));
            this.listView_result = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_file_checked = new System.Windows.Forms.Label();
            this.result_text = new System.Windows.Forms.Label();
            this.progress_text = new System.Windows.Forms.Label();
            this.total_size = new System.Windows.Forms.Label();
            this.total_files = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_result
            // 
            this.listView_result.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_result.FullRowSelect = true;
            this.listView_result.GridLines = true;
            this.listView_result.Location = new System.Drawing.Point(0, 113);
            this.listView_result.Name = "listView_result";
            this.listView_result.ShowGroups = false;
            this.listView_result.Size = new System.Drawing.Size(555, 287);
            this.listView_result.TabIndex = 0;
            this.listView_result.UseCompatibleStateImageBehavior = false;
            this.listView_result.View = System.Windows.Forms.View.Details;
            this.listView_result.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_result_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFileLocationToolStripMenuItem,
            this.filePropertiesToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 92);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFileLocationToolStripMenuItem
            // 
            this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
            this.openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openFileLocationToolStripMenuItem.Text = "Open file location";
            this.openFileLocationToolStripMenuItem.Click += new System.EventHandler(this.openFileLocationToolStripMenuItem_Click);
            // 
            // filePropertiesToolStripMenuItem
            // 
            this.filePropertiesToolStripMenuItem.Name = "filePropertiesToolStripMenuItem";
            this.filePropertiesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.filePropertiesToolStripMenuItem.Text = "File properties";
            this.filePropertiesToolStripMenuItem.Click += new System.EventHandler(this.filePropertiesToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(175, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // lbl_file_checked
            // 
            this.lbl_file_checked.AutoSize = true;
            this.lbl_file_checked.Location = new System.Drawing.Point(12, 88);
            this.lbl_file_checked.Name = "lbl_file_checked";
            this.lbl_file_checked.Size = new System.Drawing.Size(28, 13);
            this.lbl_file_checked.TabIndex = 2;
            this.lbl_file_checked.Text = "Files";
            // 
            // result_text
            // 
            this.result_text.AutoSize = true;
            this.result_text.Location = new System.Drawing.Point(350, 60);
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(37, 13);
            this.result_text.TabIndex = 3;
            this.result_text.Text = "Result";
            // 
            // progress_text
            // 
            this.progress_text.AutoSize = true;
            this.progress_text.Location = new System.Drawing.Point(193, 60);
            this.progress_text.Name = "progress_text";
            this.progress_text.Size = new System.Drawing.Size(48, 13);
            this.progress_text.TabIndex = 4;
            this.progress_text.Text = "Progress";
            // 
            // total_size
            // 
            this.total_size.AutoSize = true;
            this.total_size.Location = new System.Drawing.Point(193, 20);
            this.total_size.Name = "total_size";
            this.total_size.Size = new System.Drawing.Size(58, 13);
            this.total_size.TabIndex = 5;
            this.total_size.Text = "Total size: ";
            // 
            // total_files
            // 
            this.total_files.AutoSize = true;
            this.total_files.Location = new System.Drawing.Point(12, 20);
            this.total_files.Name = "total_files";
            this.total_files.Size = new System.Drawing.Size(83, 13);
            this.total_files.TabIndex = 6;
            this.total_files.Text = "Number of files: ";
            // 
            // Result_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 400);
            this.Controls.Add(this.total_files);
            this.Controls.Add(this.total_size);
            this.Controls.Add(this.listView_result);
            this.Controls.Add(this.progress_text);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.lbl_file_checked);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Result_Form";
            this.Text = "Result_Form";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_result;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filePropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label lbl_file_checked;
        public System.Windows.Forms.Label result_text;
        public System.Windows.Forms.Label progress_text;
        private System.Windows.Forms.Label total_size;
        private System.Windows.Forms.Label total_files;
    }
}