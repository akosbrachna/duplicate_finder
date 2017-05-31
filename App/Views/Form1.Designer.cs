namespace duplicate_finder.App
{
    partial class File_manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(File_manager));
            this.btn_start_work = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.select_folder = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.content_match = new System.Windows.Forms.NumericUpDown();
            this.file_size_match = new System.Windows.Forms.NumericUpDown();
            this.label_content_match = new System.Windows.Forms.Label();
            this.label_file_size_match = new System.Windows.Forms.Label();
            this.label_min_file_size = new System.Windows.Forms.Label();
            this.textBox_min_file_size = new System.Windows.Forms.TextBox();
            this.lbl_dragdrop = new System.Windows.Forms.Label();
            this.list_methods = new System.Windows.Forms.ComboBox();
            this.lbl_methods = new System.Windows.Forms.Label();
            this.btn_method_config = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.content_match)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.file_size_match)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start_work
            // 
            this.btn_start_work.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start_work.Location = new System.Drawing.Point(318, 307);
            this.btn_start_work.Name = "btn_start_work";
            this.btn_start_work.Size = new System.Drawing.Size(105, 73);
            this.btn_start_work.TabIndex = 0;
            this.btn_start_work.Text = "Run";
            this.btn_start_work.UseVisualStyleBackColor = true;
            this.btn_start_work.Click += new System.EventHandler(this.btn_start_work_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 129);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(411, 160);
            this.listBox1.TabIndex = 1;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // select_folder
            // 
            this.select_folder.Location = new System.Drawing.Point(12, 100);
            this.select_folder.Name = "select_folder";
            this.select_folder.Size = new System.Drawing.Size(83, 23);
            this.select_folder.TabIndex = 6;
            this.select_folder.Text = "Select folders";
            this.select_folder.UseVisualStyleBackColor = true;
            this.select_folder.Click += new System.EventHandler(this.select_folder_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(12, 307);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(83, 23);
            this.reset_button.TabIndex = 14;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // content_match
            // 
            this.content_match.Location = new System.Drawing.Point(156, 43);
            this.content_match.Minimum = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.content_match.Name = "content_match";
            this.content_match.Size = new System.Drawing.Size(50, 20);
            this.content_match.TabIndex = 16;
            this.content_match.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.content_match.ValueChanged += new System.EventHandler(this.content_match_ValueChanged);
            // 
            // file_size_match
            // 
            this.file_size_match.Location = new System.Drawing.Point(156, 12);
            this.file_size_match.Minimum = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.file_size_match.Name = "file_size_match";
            this.file_size_match.Size = new System.Drawing.Size(48, 20);
            this.file_size_match.TabIndex = 17;
            this.file_size_match.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.file_size_match.ValueChanged += new System.EventHandler(this.file_size_match_ValueChanged);
            // 
            // label_content_match
            // 
            this.label_content_match.AutoSize = true;
            this.label_content_match.Location = new System.Drawing.Point(12, 45);
            this.label_content_match.Name = "label_content_match";
            this.label_content_match.Size = new System.Drawing.Size(123, 13);
            this.label_content_match.TabIndex = 18;
            this.label_content_match.Text = "content match (min 85%)";
            // 
            // label_file_size_match
            // 
            this.label_file_size_match.AutoSize = true;
            this.label_file_size_match.Location = new System.Drawing.Point(12, 14);
            this.label_file_size_match.Name = "label_file_size_match";
            this.label_file_size_match.Size = new System.Drawing.Size(121, 13);
            this.label_file_size_match.TabIndex = 19;
            this.label_file_size_match.Text = "file size match (min 85%)";
            // 
            // label_min_file_size
            // 
            this.label_min_file_size.AutoSize = true;
            this.label_min_file_size.Location = new System.Drawing.Point(230, 14);
            this.label_min_file_size.Name = "label_min_file_size";
            this.label_min_file_size.Size = new System.Drawing.Size(124, 13);
            this.label_min_file_size.TabIndex = 20;
            this.label_min_file_size.Text = "Minimum file size in bytes";
            // 
            // textBox_min_file_size
            // 
            this.textBox_min_file_size.Location = new System.Drawing.Point(360, 11);
            this.textBox_min_file_size.Name = "textBox_min_file_size";
            this.textBox_min_file_size.Size = new System.Drawing.Size(62, 20);
            this.textBox_min_file_size.TabIndex = 21;
            this.textBox_min_file_size.Text = "50000";
            this.textBox_min_file_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_min_file_size.TextChanged += new System.EventHandler(this.textBox_min_file_size_TextChanged);
            // 
            // lbl_dragdrop
            // 
            this.lbl_dragdrop.AutoSize = true;
            this.lbl_dragdrop.Location = new System.Drawing.Point(104, 105);
            this.lbl_dragdrop.Name = "lbl_dragdrop";
            this.lbl_dragdrop.Size = new System.Drawing.Size(76, 13);
            this.lbl_dragdrop.TabIndex = 23;
            this.lbl_dragdrop.Text = "or Drop folders";
            // 
            // list_methods
            // 
            this.list_methods.FormattingEnabled = true;
            this.list_methods.Items.AddRange(new object[] {
            "Statistical",
            "Simple"});
            this.list_methods.Location = new System.Drawing.Point(301, 43);
            this.list_methods.Name = "list_methods";
            this.list_methods.Size = new System.Drawing.Size(121, 21);
            this.list_methods.TabIndex = 24;
            this.list_methods.Text = "Statistical";
            // 
            // lbl_methods
            // 
            this.lbl_methods.AutoSize = true;
            this.lbl_methods.Location = new System.Drawing.Point(230, 46);
            this.lbl_methods.Name = "lbl_methods";
            this.lbl_methods.Size = new System.Drawing.Size(51, 13);
            this.lbl_methods.TabIndex = 25;
            this.lbl_methods.Text = "Methods:";
            // 
            // btn_method_config
            // 
            this.btn_method_config.Location = new System.Drawing.Point(301, 70);
            this.btn_method_config.Name = "btn_method_config";
            this.btn_method_config.Size = new System.Drawing.Size(121, 23);
            this.btn_method_config.TabIndex = 26;
            this.btn_method_config.Text = "Config";
            this.btn_method_config.UseVisualStyleBackColor = true;
            // 
            // File_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 391);
            this.Controls.Add(this.btn_method_config);
            this.Controls.Add(this.lbl_methods);
            this.Controls.Add(this.list_methods);
            this.Controls.Add(this.lbl_dragdrop);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.label_min_file_size);
            this.Controls.Add(this.label_file_size_match);
            this.Controls.Add(this.textBox_min_file_size);
            this.Controls.Add(this.label_content_match);
            this.Controls.Add(this.file_size_match);
            this.Controls.Add(this.content_match);
            this.Controls.Add(this.select_folder);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_start_work);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "File_manager";
            this.Text = "Duplicate File Finder";
            ((System.ComponentModel.ISupportInitialize)(this.content_match)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.file_size_match)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start_work;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button select_folder;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.NumericUpDown content_match;
        private System.Windows.Forms.NumericUpDown file_size_match;
        private System.Windows.Forms.Label label_content_match;
        private System.Windows.Forms.Label label_file_size_match;
        private System.Windows.Forms.Label label_min_file_size;
        private System.Windows.Forms.TextBox textBox_min_file_size;
        private System.Windows.Forms.Label lbl_dragdrop;
        private System.Windows.Forms.ComboBox list_methods;
        private System.Windows.Forms.Label lbl_methods;
        private System.Windows.Forms.Button btn_method_config;
    }
}

