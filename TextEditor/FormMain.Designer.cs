
namespace TextEditor
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdChooseFile = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.sfdNewFile = new System.Windows.Forms.SaveFileDialog();
            this.buttonopenEarlier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdChooseFile
            // 
            this.ofdChooseFile.FileName = "openFileDialog1";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(235, 29);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Location = new System.Drawing.Point(12, 47);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(235, 29);
            this.buttonCreateFile.TabIndex = 1;
            this.buttonCreateFile.Text = "Создать файл";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            this.buttonCreateFile.Click += new System.EventHandler(this.buttonCreateFile_Click);
            // 
            // buttonopenEarlier
            // 
            this.buttonopenEarlier.Location = new System.Drawing.Point(12, 82);
            this.buttonopenEarlier.Name = "buttonopenEarlier";
            this.buttonopenEarlier.Size = new System.Drawing.Size(235, 29);
            this.buttonopenEarlier.TabIndex = 2;
            this.buttonopenEarlier.Text = "Открыть ранее закрытые файлы";
            this.buttonopenEarlier.UseVisualStyleBackColor = true;
            this.buttonopenEarlier.Click += new System.EventHandler(this.buttonopenEarlier_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 130);
            this.Controls.Add(this.buttonopenEarlier);
            this.Controls.Add(this.buttonCreateFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "FormMain";
            this.Text = "Notepad+";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdChooseFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.SaveFileDialog sfdNewFile;
        private System.Windows.Forms.Button buttonopenEarlier;
    }
}

