
namespace TextEditor
{
    partial class FormEditFile
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxTexts = new System.Windows.Forms.ListBox();
            this.ofdNewFile = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFileText = new System.Windows.Forms.RichTextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.sfdNewFile = new System.Windows.Forms.SaveFileDialog();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interval1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interval3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interval5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interval10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerAutosave = new System.Windows.Forms.Timer(this.components);
            this.fdChangeFont = new System.Windows.Forms.FontDialog();
            this.cdChangeColor = new System.Windows.Forms.ColorDialog();
            this.cmsMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(975, 587);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(143, 44);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxTexts
            // 
            this.listBoxTexts.FormattingEnabled = true;
            this.listBoxTexts.ItemHeight = 15;
            this.listBoxTexts.Location = new System.Drawing.Point(12, 24);
            this.listBoxTexts.Name = "listBoxTexts";
            this.listBoxTexts.Size = new System.Drawing.Size(106, 604);
            this.listBoxTexts.TabIndex = 2;
            this.listBoxTexts.DoubleClick += new System.EventHandler(this.listBoxTexts_DoubleClick);
            // 
            // ofdNewFile
            // 
            this.ofdNewFile.FileName = "openFileDialog1";
            // 
            // textBoxFileText
            // 
            this.textBoxFileText.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFileText.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFileText.Location = new System.Drawing.Point(124, 52);
            this.textBoxFileText.Name = "textBoxFileText";
            this.textBoxFileText.Size = new System.Drawing.Size(995, 579);
            this.textBoxFileText.TabIndex = 10;
            this.textBoxFileText.Text = "";
            this.textBoxFileText.TextChanged += new System.EventHandler(this.textBoxFileText_TextChanged);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.BackColor = System.Drawing.SystemColors.Control;
            this.labelFile.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFile.Location = new System.Drawing.Point(124, 24);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(146, 25);
            this.labelFile.TabIndex = 12;
            this.labelFile.Text = "Текущий файл:";
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.AutoSize = true;
            this.labelCurrentFile.BackColor = System.Drawing.SystemColors.Control;
            this.labelCurrentFile.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCurrentFile.Location = new System.Drawing.Point(276, 24);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(93, 25);
            this.labelCurrentFile.TabIndex = 13;
            this.labelCurrentFile.Text = "file_name";
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.EditFontToolStripMenuItem});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsMain.Size = new System.Drawing.Size(157, 92);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.PasteToolStripMenuItem.Text = "Вставить";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // EditFontToolStripMenuItem
            // 
            this.EditFontToolStripMenuItem.Name = "EditFontToolStripMenuItem";
            this.EditFontToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.EditFontToolStripMenuItem.Text = "Задать формат";
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1135, 24);
            this.msMain.TabIndex = 15;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewFileToolStripMenuItem,
            this.openNewWindowToolStripMenuItem,
            this.createNewFileToolStripMenuItem,
            this.createNewWindowToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openNewFileToolStripMenuItem
            // 
            this.openNewFileToolStripMenuItem.Name = "openNewFileToolStripMenuItem";
            this.openNewFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openNewFileToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.openNewFileToolStripMenuItem.Text = "Открыть файл в этой вкладке";
            this.openNewFileToolStripMenuItem.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // openNewWindowToolStripMenuItem
            // 
            this.openNewWindowToolStripMenuItem.Name = "openNewWindowToolStripMenuItem";
            this.openNewWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openNewWindowToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.openNewWindowToolStripMenuItem.Text = "Открыть файл в новой вкладке";
            this.openNewWindowToolStripMenuItem.Click += new System.EventHandler(this.openFileNewWindowToolStripMenuItem_Click);
            // 
            // createNewFileToolStripMenuItem
            // 
            this.createNewFileToolStripMenuItem.Name = "createNewFileToolStripMenuItem";
            this.createNewFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createNewFileToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.createNewFileToolStripMenuItem.Text = "Создать файл в этой вкладке";
            this.createNewFileToolStripMenuItem.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // createNewWindowToolStripMenuItem
            // 
            this.createNewWindowToolStripMenuItem.Name = "createNewWindowToolStripMenuItem";
            this.createNewWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.createNewWindowToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.createNewWindowToolStripMenuItem.Text = "Создать файл в новой вкладке";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.saveToolStripMenuItem.Text = "Сохранить текущий файл";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.saveAllToolStripMenuItem.Text = "Сохранить всё";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.closeToolStripMenuItem.Text = "Закрыть текущий файл";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.backColorToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.formatToolStripMenuItem.Text = "Формат";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.fontToolStripMenuItem.Text = "Установить шрифт выделенного текста";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.colorToolStripMenuItem.Text = "Установить цвет шрифта выделенного текста";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.backColorToolStripMenuItem.Text = "Установить фоновый цвет выделенного текста";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.autosaveToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.optionsToolStripMenuItem.Text = "Настройки";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.themeToolStripMenuItem.Text = "Тема";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Checked = true;
            this.lightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.lightToolStripMenuItem.Text = "Светлая";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.darkToolStripMenuItem.Text = "Тёмная";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // autosaveToolStripMenuItem
            // 
            this.autosaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interval1ToolStripMenuItem,
            this.interval3ToolStripMenuItem,
            this.interval5ToolStripMenuItem,
            this.interval10ToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.autosaveToolStripMenuItem.Name = "autosaveToolStripMenuItem";
            this.autosaveToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.autosaveToolStripMenuItem.Text = "Авто-сохранение";
            // 
            // interval1ToolStripMenuItem
            // 
            this.interval1ToolStripMenuItem.Name = "interval1ToolStripMenuItem";
            this.interval1ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.interval1ToolStripMenuItem.Text = "1 минута";
            this.interval1ToolStripMenuItem.Click += new System.EventHandler(this.interval1ToolStripMenuItem_Click);
            // 
            // interval3ToolStripMenuItem
            // 
            this.interval3ToolStripMenuItem.Name = "interval3ToolStripMenuItem";
            this.interval3ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.interval3ToolStripMenuItem.Text = "3 минуты";
            this.interval3ToolStripMenuItem.Click += new System.EventHandler(this.interval3ToolStripMenuItem_Click);
            // 
            // interval5ToolStripMenuItem
            // 
            this.interval5ToolStripMenuItem.Name = "interval5ToolStripMenuItem";
            this.interval5ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.interval5ToolStripMenuItem.Text = "5 минут";
            this.interval5ToolStripMenuItem.Click += new System.EventHandler(this.interval5ToolStripMenuItem_Click);
            // 
            // interval10ToolStripMenuItem
            // 
            this.interval10ToolStripMenuItem.Name = "interval10ToolStripMenuItem";
            this.interval10ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.interval10ToolStripMenuItem.Text = "10 минут";
            this.interval10ToolStripMenuItem.Click += new System.EventHandler(this.interval10ToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Checked = true;
            this.disableToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.disableToolStripMenuItem.Text = "Отключить";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // timerAutosave
            // 
            this.timerAutosave.Interval = 180000;
            this.timerAutosave.Tick += new System.EventHandler(this.timerAutosave_Tick);
            // 
            // FormEditFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1135, 652);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.labelCurrentFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.textBoxFileText);
            this.Controls.Add(this.listBoxTexts);
            this.Controls.Add(this.buttonSave);
            this.MainMenuStrip = this.msMain;
            this.Name = "FormEditFile";
            this.Text = "Notepad+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditFile_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditFile_FormClosed);
            this.Load += new System.EventHandler(this.FormEditFile_Load);
            this.cmsMain.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxTexts;
        private System.Windows.Forms.OpenFileDialog ofdNewFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label labelCurrentFile;
        public System.Windows.Forms.RichTextBox textBoxFileText;
        private System.Windows.Forms.SaveFileDialog sfdNewFile;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditFontToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autosaveToolStripMenuItem;
        private System.Windows.Forms.Timer timerAutosave;
        private System.Windows.Forms.ToolStripMenuItem interval1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interval3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interval5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interval10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.FontDialog fdChangeFont;
        private System.Windows.Forms.ColorDialog cdChangeColor;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}