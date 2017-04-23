namespace TinyJpgPngCompress
{
    partial class Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_folder = new System.Windows.Forms.TextBox();
            this.button_folderSearch = new System.Windows.Forms.Button();
            this.textBox_apiKey = new System.Windows.Forms.TextBox();
            this.label_apiKey = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.label_compressionCount = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_currentFile = new System.Windows.Forms.TextBox();
            this.label_compression = new System.Windows.Forms.Label();
            this.label_directory = new System.Windows.Forms.Label();
            this.listBox_log = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_folder
            // 
            this.textBox_folder.Location = new System.Drawing.Point(112, 9);
            this.textBox_folder.Name = "textBox_folder";
            this.textBox_folder.Size = new System.Drawing.Size(335, 22);
            this.textBox_folder.TabIndex = 0;
            // 
            // button_folderSearch
            // 
            this.button_folderSearch.Location = new System.Drawing.Point(453, 9);
            this.button_folderSearch.Name = "button_folderSearch";
            this.button_folderSearch.Size = new System.Drawing.Size(41, 23);
            this.button_folderSearch.TabIndex = 1;
            this.button_folderSearch.Text = "...";
            this.button_folderSearch.UseVisualStyleBackColor = true;
            this.button_folderSearch.Click += new System.EventHandler(this.button_folderSearch_Click);
            // 
            // textBox_apiKey
            // 
            this.textBox_apiKey.Location = new System.Drawing.Point(112, 65);
            this.textBox_apiKey.Name = "textBox_apiKey";
            this.textBox_apiKey.Size = new System.Drawing.Size(335, 22);
            this.textBox_apiKey.TabIndex = 2;
            // 
            // label_apiKey
            // 
            this.label_apiKey.AutoSize = true;
            this.label_apiKey.Location = new System.Drawing.Point(12, 65);
            this.label_apiKey.Name = "label_apiKey";
            this.label_apiKey.Size = new System.Drawing.Size(60, 17);
            this.label_apiKey.TabIndex = 3;
            this.label_apiKey.Text = "Api Key:";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(250, 90);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(13, 17);
            this.label_min.TabIndex = 4;
            this.label_min.Text = "-";
            // 
            // label_compressionCount
            // 
            this.label_compressionCount.AutoSize = true;
            this.label_compressionCount.Location = new System.Drawing.Point(109, 90);
            this.label_compressionCount.Name = "label_compressionCount";
            this.label_compressionCount.Size = new System.Drawing.Size(135, 17);
            this.label_compressionCount.TabIndex = 6;
            this.label_compressionCount.Text = "Compression Count:";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(112, 122);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(229, 50);
            this.button_start.TabIndex = 7;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox_currentFile
            // 
            this.textBox_currentFile.Location = new System.Drawing.Point(112, 37);
            this.textBox_currentFile.Name = "textBox_currentFile";
            this.textBox_currentFile.ReadOnly = true;
            this.textBox_currentFile.Size = new System.Drawing.Size(335, 22);
            this.textBox_currentFile.TabIndex = 8;
            // 
            // label_compression
            // 
            this.label_compression.AutoSize = true;
            this.label_compression.Location = new System.Drawing.Point(12, 37);
            this.label_compression.Name = "label_compression";
            this.label_compression.Size = new System.Drawing.Size(94, 17);
            this.label_compression.TabIndex = 9;
            this.label_compression.Text = "Compressing:";
            // 
            // label_directory
            // 
            this.label_directory.AutoSize = true;
            this.label_directory.Location = new System.Drawing.Point(12, 9);
            this.label_directory.Name = "label_directory";
            this.label_directory.Size = new System.Drawing.Size(69, 17);
            this.label_directory.TabIndex = 10;
            this.label_directory.Text = "Directory:";
            // 
            // listBox_log
            // 
            this.listBox_log.FormattingEnabled = true;
            this.listBox_log.HorizontalScrollbar = true;
            this.listBox_log.ItemHeight = 16;
            this.listBox_log.Location = new System.Drawing.Point(15, 178);
            this.listBox_log.Name = "listBox_log";
            this.listBox_log.Size = new System.Drawing.Size(479, 148);
            this.listBox_log.TabIndex = 11;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(510, 338);
            this.Controls.Add(this.listBox_log);
            this.Controls.Add(this.label_directory);
            this.Controls.Add(this.label_compression);
            this.Controls.Add(this.textBox_currentFile);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_compressionCount);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_apiKey);
            this.Controls.Add(this.textBox_apiKey);
            this.Controls.Add(this.button_folderSearch);
            this.Controls.Add(this.textBox_folder);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.Text = "TinyJPG/PNG - GitHub limitX91 - V.0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_folder;
        private System.Windows.Forms.Button button_folderSearch;
        private System.Windows.Forms.TextBox textBox_apiKey;
        private System.Windows.Forms.Label label_apiKey;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_compressionCount;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox_currentFile;
        private System.Windows.Forms.Label label_compression;
        private System.Windows.Forms.Label label_directory;
        private System.Windows.Forms.ListBox listBox_log;
    }
}

