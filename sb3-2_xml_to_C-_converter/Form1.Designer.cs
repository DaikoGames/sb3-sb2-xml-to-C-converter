namespace sb3_to_C__converter__extra_features_
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.FileSearcherF = new System.Windows.Forms.Button();
            this.FileDialogFile = new System.Windows.Forms.OpenFileDialog();
            this.FolderDialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.Filename = new System.Windows.Forms.TextBox();
            this.OutputFolder = new System.Windows.Forms.TextBox();
            this.FolderSearcher = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // FileSearcherF
            // 
            this.FileSearcherF.Location = new System.Drawing.Point(672, 38);
            this.FileSearcherF.Name = "FileSearcherF";
            this.FileSearcherF.Size = new System.Drawing.Size(32, 32);
            this.FileSearcherF.TabIndex = 0;
            this.FileSearcherF.Text = "...";
            this.FileSearcherF.UseVisualStyleBackColor = true;
            this.FileSearcherF.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileDialogFile
            // 
            this.FileDialogFile.FileName = "openFileDialog1";
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(58, 43);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(610, 22);
            this.FilePath.TabIndex = 1;
            this.FilePath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Filename
            // 
            this.Filename.Location = new System.Drawing.Point(58, 118);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(608, 22);
            this.Filename.TabIndex = 2;
            this.Filename.TextChanged += new System.EventHandler(this.Filename_TextChanged);
            // 
            // OutputFolder
            // 
            this.OutputFolder.Location = new System.Drawing.Point(58, 186);
            this.OutputFolder.Name = "OutputFolder";
            this.OutputFolder.Size = new System.Drawing.Size(610, 22);
            this.OutputFolder.TabIndex = 3;
            this.OutputFolder.TextChanged += new System.EventHandler(this.OutputFolder_TextChanged);
            // 
            // FolderSearcher
            // 
            this.FolderSearcher.Location = new System.Drawing.Point(672, 182);
            this.FolderSearcher.Name = "FolderSearcher";
            this.FolderSearcher.Size = new System.Drawing.Size(32, 32);
            this.FolderSearcher.TabIndex = 4;
            this.FolderSearcher.Text = "...";
            this.FolderSearcher.UseVisualStyleBackColor = true;
            this.FolderSearcher.Click += new System.EventHandler(this.FolderSearcher_Click);
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(329, 303);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 23);
            this.convert.TabIndex = 5;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(58, 255);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(646, 23);
            this.Progress.TabIndex = 6;
            this.Progress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 366);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.FolderSearcher);
            this.Controls.Add(this.OutputFolder);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.FileSearcherF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Converter";
            this.Text = "sb3/2 xml to C# converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileSearcherF;
        private System.Windows.Forms.OpenFileDialog FileDialogFile;
        private System.Windows.Forms.FolderBrowserDialog FolderDialogFolder;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.TextBox Filename;
        private System.Windows.Forms.TextBox OutputFolder;
        private System.Windows.Forms.Button FolderSearcher;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.ProgressBar Progress;
    }
}

