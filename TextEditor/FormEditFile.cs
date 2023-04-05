using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    /// <summary>
    /// Форма, позволяющая редактировать текст.
    /// </summary>
    public partial class FormEditFile : Form
    {
        // Текущий файл и его индекс в списке.
        FileInfo currentFile;
        int currentIndex;

        // Список файлов.
        List<FileInfo> files = new List<FileInfo>();

        // Переменная типа bool говорит, нужно ли загружать ранее открытые файлы.
        private bool loadEarlierFiles;

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        /// <param name="path"> Путь к открываемому файлу. Если его нет, строка пуста. </param>
        /// <param name="earlier"> Говорит, нужно ли загружать ранее открытые файлы. </param>
        public FormEditFile(string path, bool earlier)
        {
            currentFile = new FileInfo(path);
            loadEarlierFiles = earlier;
            InitializeComponent();
        }

        /// <summary>
        /// Событие загрузки формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditFile_Load(object sender, EventArgs e)
        {
            Init();
            if (!loadEarlierFiles)
            {
                files.Add(currentFile);
                currentIndex = 0;
                listBoxTexts.Items.Add(currentFile.Name);
                labelCurrentFile.Text = currentFile.Name;
                ReadFile(currentFile);
                FileInfo.CopyText(currentFile.Content, textBoxFileText);
            }
            textBoxFileText.ContextMenuStrip = cmsMain;
            sfdNewFile.Filter = "Текстовый файл(*.txt)|*.txt|Файл rtf(*.rtf)|*.rtf|Все файлы(*.*)|*.*";
            
        }

        /// <summary>
        /// Инициализирует ранее сохранённые данные.
        /// </summary>
        private void Init()
        {
            setLightTheme();
            if (loadEarlierFiles)
            {
                var filePaths = File.ReadAllLines("files.yy");
                if (filePaths != null)
                {
                    foreach (var el in filePaths)
                    {
                        currentFile = new FileInfo(el);
                        try
                        {
                            files.Add(currentFile);
                            listBoxTexts.Items.Add(currentFile.Name);
                            labelCurrentFile.Text = currentFile.Name;
                            ReadFile(currentFile);
                            FileInfo.CopyText(currentFile.Content, textBoxFileText);
                        }
                        catch (FileNotFoundException)
                        {
                            continue;
                        }
                    }
                }
            }
            if (File.Exists("opt.yy"))
            {
                var options = Array.ConvertAll(File.ReadAllText("opt.yy").Split(';'), int.Parse);
                switch (options[0])
                {
                    case 0:
                        timerAutosave.Enabled = false;
                        interval1ToolStripMenuItem.Checked = false;
                        interval3ToolStripMenuItem.Checked = false;
                        interval5ToolStripMenuItem.Checked = false;
                        interval10ToolStripMenuItem.Checked = false;
                        disableToolStripMenuItem.Checked = true;
                        break;
                    case 1:
                        timerAutosave.Enabled = true;
                        timerAutosave.Interval = 60 * 1000;
                        interval1ToolStripMenuItem.Checked = true;
                        interval3ToolStripMenuItem.Checked = false;
                        interval5ToolStripMenuItem.Checked = false;
                        interval10ToolStripMenuItem.Checked = false;
                        disableToolStripMenuItem.Checked = false;
                        break;
                    case 2:
                        timerAutosave.Enabled = true;
                        timerAutosave.Interval = 3 * 60 * 1000;
                        interval1ToolStripMenuItem.Checked = false;
                        interval3ToolStripMenuItem.Checked = true;
                        interval5ToolStripMenuItem.Checked = false;
                        interval10ToolStripMenuItem.Checked = false;
                        disableToolStripMenuItem.Checked = false;
                        break;
                    case 3:
                        timerAutosave.Enabled = true;
                        timerAutosave.Interval = 5 * 60 * 1000;
                        interval1ToolStripMenuItem.Checked = false;
                        interval3ToolStripMenuItem.Checked = false;
                        interval5ToolStripMenuItem.Checked = true;
                        interval10ToolStripMenuItem.Checked = false;
                        disableToolStripMenuItem.Checked = false;
                        break;
                    default:
                        timerAutosave.Enabled = true;
                        timerAutosave.Interval = 10 * 60 * 1000;
                        interval1ToolStripMenuItem.Checked = false;
                        interval3ToolStripMenuItem.Checked = false;
                        interval5ToolStripMenuItem.Checked = false;
                        interval10ToolStripMenuItem.Checked = true;
                        disableToolStripMenuItem.Checked = false;
                        break;
                }
                if (options[1] == 0)
                {
                    lightToolStripMenuItem.Checked = true;
                    darkToolStripMenuItem.Checked = false;
                    setLightTheme();
                }
                else
                {
                    lightToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = true;
                    setDarkTheme();
                }
            }
        }

        /// <summary>
        /// Сохраняет текст файла.
        /// </summary>
        /// <param name="file"> Файл, который надо сохранить. </param>
        /// <param name="origin"> источник текста. </param>
        private void WriteFile(FileInfo file, RichTextBox origin)
        {
            if (file.Name.EndsWith(".rtf"))
                origin.SaveFile(file.FilePath, RichTextBoxStreamType.RichText);
            else
                origin.SaveFile(file.FilePath, RichTextBoxStreamType.PlainText);
        }

        /// <summary>
        /// Считывает текст из файла.
        /// </summary>
        /// <param name="file"> Сохраняет считанный файл. </param>
        private void ReadFile(FileInfo file)
        {
            textBoxFileText.TextChanged -= textBoxFileText_TextChanged;
            try
            {
                if (file.Name.EndsWith(".rtf"))
                    textBoxFileText.LoadFile(file.FilePath, RichTextBoxStreamType.RichText);
                else
                    textBoxFileText.LoadFile(file.FilePath, RichTextBoxStreamType.PlainText);
            }
            catch (ArgumentException)
            {
                textBoxFileText.LoadFile(file.FilePath, RichTextBoxStreamType.PlainText);
            }
            finally
            {
                textBoxFileText.TextChanged += textBoxFileText_TextChanged;
            }
        }

        /// <summary>
        /// Событие сохранения файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Вы уверены, что хотите сохранить изменения в {currentFile.Name}?",
                "Подтверждение действий", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                WriteFile(currentFile, textBoxFileText);
                currentFile.IsChanged = false;
            }
        }

        /// <summary>
        /// Событие процесса закрытия формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileInfo.CopyText(currentFile.Content, textBoxFileText);
            foreach (var file in files)
            {
                if (file.IsChanged)
                {
                    DialogResult result = MessageBox.Show($"В тексте {file.Name} есть несохранённые изменения. Хотите их сохранить?",
                            "Несохранённые изменения", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                        WriteFile(file, file.Content);
                    if (result == DialogResult.Cancel)
                        e.Cancel = true;
                }
            }
        }
       
        /// <summary>
        /// Событие открытия нового файла в этом окне.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ofdNewFile.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
                var path = ofdNewFile.FileName;
                var file = new FileInfo(path);
                files.Add(file);
                listBoxTexts.Items.Add(file.Name);
                FileInfo.CopyText(currentFile.Content, textBoxFileText);
                currentIndex = files.Count - 1;
                currentFile = files[currentIndex];
                labelCurrentFile.Text = currentFile.Name;
                ReadFile(file);
                FileInfo.CopyText(currentFile.Content, textBoxFileText);
            }
            catch
            {
                MessageBox.Show("Ошибка доступа!");
            }
        }

        /// <summary>
        /// Класс файла.
        /// </summary>
        class FileInfo
        {
            public string Name { get; }
            public string FilePath { get; }
            public RichTextBox Content { get; set; }
            public bool IsChanged { get; set; }

            /// <summary>
            /// Конструктор.
            /// </summary>
            /// <param name="path"> Путь к файлу. </param>
            public FileInfo(string path)
            {
                FilePath = path;
                Name = path[(path.LastIndexOf(Path.DirectorySeparatorChar) + 1)..];
                Content = new RichTextBox();
            }
            
            /// <summary>
            /// Копирует текст из файла b в файл a.
            /// </summary>
            /// <param name="a"> Файл, в который запишется новый текст. </param>
            /// <param name="b"> Источник текста. </param>
            public static void CopyText(RichTextBox a, RichTextBox b)
            {
                a.Text = "";
                for (var i = 0; i < b.Text.Length; i++)
                {
                    b.Select(i, 1);
                    a.SelectionFont = b.SelectionFont;
                    a.SelectionColor = b.SelectionColor;
                    a.SelectionBackColor = b.SelectionBackColor;
                    a.AppendText(b.Text[i].ToString());
                }
            }
        }

        /// <summary>
        /// Событие создания файла в этом окне.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var result = sfdNewFile.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
                var path = sfdNewFile.FileName;
                if (path.EndsWith(".rtf"))
                    File.WriteAllText(path, @"{\rtf}");
                else
                    File.WriteAllText(path, "");
                var file = new FileInfo(path);
                files.Add(file);
                listBoxTexts.Items.Add(file.Name);
            }
            catch
            {
                MessageBox.Show("Ошибка доступа!");
            }
        }

        /// <summary>
        /// Опция контекстного меню "Копировать".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxFileText.SelectedText);
        }

        /// <summary>
        /// Опция контекстного меню "Вырезать".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxFileText.SelectedText);
            textBoxFileText.SelectedText = "";
        }

        /// <summary>
        /// Опция контекстного меню "Вставить".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxFileText.Text = textBoxFileText.Text.Insert(textBoxFileText.SelectionStart, Clipboard.GetText());
        }

        /// <summary>
        /// Событие открытия окна в новой вкладке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileNewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = ofdNewFile.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            var fef = new FormEditFile(ofdNewFile.FileName, false);
            fef.Show();
        }

        /// <summary>
        /// Опция в 1 минуту интервала для таймера автосохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void interval1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerAutosave.Enabled = true;
            timerAutosave.Interval = 60 * 1000;
            interval1ToolStripMenuItem.Checked = true;
            interval3ToolStripMenuItem.Checked = false;
            interval5ToolStripMenuItem.Checked = false;
            interval10ToolStripMenuItem.Checked = false;
            disableToolStripMenuItem.Checked = false;
        }

        /// <summary>
        /// Опция в 3 минуты интервала для таймера автосохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void interval3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerAutosave.Enabled = true;
            timerAutosave.Interval = 3 * 60 * 1000;
            interval1ToolStripMenuItem.Checked = false;
            interval3ToolStripMenuItem.Checked = true;
            interval5ToolStripMenuItem.Checked = false;
            interval10ToolStripMenuItem.Checked = false;
            disableToolStripMenuItem.Checked = false;
        }

        /// <summary>
        /// Опция в 5 минут интервала для таймера автосохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void interval5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerAutosave.Enabled = true;
            timerAutosave.Interval = 5 * 60 * 1000;
            interval1ToolStripMenuItem.Checked = false;
            interval3ToolStripMenuItem.Checked = false;
            interval5ToolStripMenuItem.Checked = true;
            interval10ToolStripMenuItem.Checked = false;
            disableToolStripMenuItem.Checked = false;
        }

        /// <summary>
        /// Опция в 10 минут интервала для таймера автосохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void interval10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerAutosave.Enabled = true;
            timerAutosave.Interval = 10 * 60 * 1000;
            interval1ToolStripMenuItem.Checked = false;
            interval3ToolStripMenuItem.Checked = false;
            interval5ToolStripMenuItem.Checked = false;
            interval10ToolStripMenuItem.Checked = true;
            disableToolStripMenuItem.Checked = false;
        }

        /// <summary>
        /// Событие тика таймера автосохранения. 
        /// Сохраняет текущую версию файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerAutosave_Tick(object sender, EventArgs e)
        {
            FileInfo.CopyText(currentFile.Content, textBoxFileText);
            foreach (var file in files)
                WriteFile(file, file.Content);
        }

        /// <summary>
        /// Отключение таймера автосохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerAutosave.Enabled = false;
            interval1ToolStripMenuItem.Checked = false;
            interval3ToolStripMenuItem.Checked = false;
            interval5ToolStripMenuItem.Checked = false;
            interval10ToolStripMenuItem.Checked = false;
            disableToolStripMenuItem.Checked = true;
        }

        /// <summary>
        /// Опция меню для настройки шрифта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdChangeFont.ShowDialog() == DialogResult.OK)
                textBoxFileText.SelectionFont = fdChangeFont.Font;
        }

        /// <summary>
        /// Опция меню для изменения цвета шрифта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cdChangeColor.ShowDialog() == DialogResult.OK)
                textBoxFileText.SelectionColor = cdChangeColor.Color;
        }

        /// <summary>
        /// Опция для изменения фона шрифта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cdChangeColor.ShowDialog() == DialogResult.OK)
                textBoxFileText.SelectionBackColor = cdChangeColor.Color;
        }

        /// <summary>
        /// Событие двойного нажатия по списку.
        /// Сохраняет содержимое текущего файла, выводит содержимое выбранного.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxTexts_DoubleClick(object sender, EventArgs e)
        {
            textBoxFileText.TextChanged -= textBoxFileText_TextChanged;
            FileInfo.CopyText(currentFile.Content, textBoxFileText);
            try
            {
                currentIndex = listBoxTexts.SelectedIndex;
                currentFile = files[currentIndex];
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбран элемент!");
                return;
            }

            labelCurrentFile.Text = currentFile.Name;

            FileInfo.CopyText(textBoxFileText, currentFile.Content);
            textBoxFileText.TextChanged += textBoxFileText_TextChanged;
        }

        /// <summary>
        /// Сохраняет все файлы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo.CopyText(currentFile.Content, textBoxFileText);
            foreach (var file in files)
            {
                WriteFile(file, file.Content);
                file.IsChanged = false;
            }
        }

        /// <summary>
        /// Событие изменения текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFileText_TextChanged(object sender, EventArgs e)
        {
            currentFile.IsChanged = true;
        }

        /// <summary>
        /// Устанавливает светлую тему.
        /// </summary>
        public void setLightTheme()
        {
            this.BackColor = SystemColors.Control;
            labelFile.BackColor = SystemColors.Control;
            labelFile.ForeColor = SystemColors.ControlText;
            msMain.BackColor = SystemColors.Control;
            msMain.BackColor = SystemColors.Control;
            textBoxFileText.BackColor = SystemColors.Window;
            listBoxTexts.BackColor = SystemColors.Window;
            labelCurrentFile.BackColor = SystemColors.Control;
            labelCurrentFile.ForeColor = SystemColors.ControlText;

            fileToolStripMenuItem.BackColor = SystemColors.Control;
            fileToolStripMenuItem.ForeColor = SystemColors.ControlText;
            editToolStripMenuItem.BackColor = SystemColors.Control;
            editToolStripMenuItem.ForeColor = SystemColors.ControlText;
            formatToolStripMenuItem.BackColor = SystemColors.Control;
            formatToolStripMenuItem.ForeColor = SystemColors.ControlText;
            optionsToolStripMenuItem.BackColor = SystemColors.Control;
            optionsToolStripMenuItem.ForeColor = SystemColors.ControlText;
            openNewFileToolStripMenuItem.BackColor = SystemColors.Control;
            openNewFileToolStripMenuItem.ForeColor = SystemColors.ControlText;
            openNewWindowToolStripMenuItem.BackColor = SystemColors.Control;
            openNewWindowToolStripMenuItem.ForeColor = SystemColors.ControlText;
            createNewFileToolStripMenuItem.BackColor = SystemColors.Control;
            createNewFileToolStripMenuItem.ForeColor = SystemColors.ControlText;
            createNewWindowToolStripMenuItem.BackColor = SystemColors.Control;
            createNewWindowToolStripMenuItem.ForeColor = SystemColors.ControlText;
            saveToolStripMenuItem.BackColor = SystemColors.Control;
            saveToolStripMenuItem.ForeColor = SystemColors.ControlText;
            saveAllToolStripMenuItem.BackColor = SystemColors.Control;
            saveAllToolStripMenuItem.ForeColor = SystemColors.ControlText;
            closeToolStripMenuItem.BackColor = SystemColors.Control;
            closeToolStripMenuItem.ForeColor = SystemColors.ControlText;
            fontToolStripMenuItem.BackColor = SystemColors.Control;
            fontToolStripMenuItem.ForeColor = SystemColors.ControlText;
            colorToolStripMenuItem.BackColor = SystemColors.Control;
            colorToolStripMenuItem.ForeColor = SystemColors.ControlText;
            backColorToolStripMenuItem.BackColor = SystemColors.Control;
            backColorToolStripMenuItem.ForeColor = SystemColors.ControlText;
            themeToolStripMenuItem.BackColor = SystemColors.Control;
            themeToolStripMenuItem.ForeColor = SystemColors.ControlText;
            autosaveToolStripMenuItem.BackColor = SystemColors.Control;
            autosaveToolStripMenuItem.ForeColor = SystemColors.ControlText;
            interval1ToolStripMenuItem.BackColor = SystemColors.Control;
            interval1ToolStripMenuItem.ForeColor = SystemColors.ControlText;
            interval3ToolStripMenuItem.BackColor = SystemColors.Control;
            interval3ToolStripMenuItem.ForeColor = SystemColors.ControlText;
            interval5ToolStripMenuItem.BackColor = SystemColors.Control;
            interval5ToolStripMenuItem.ForeColor = SystemColors.ControlText;
            interval10ToolStripMenuItem.BackColor = SystemColors.Control;
            interval10ToolStripMenuItem.ForeColor = SystemColors.ControlText;
            disableToolStripMenuItem.BackColor = SystemColors.Control;
            disableToolStripMenuItem.ForeColor = SystemColors.ControlText;
            lightToolStripMenuItem.BackColor = SystemColors.Control;
            lightToolStripMenuItem.ForeColor = SystemColors.ControlText;
            darkToolStripMenuItem.BackColor = SystemColors.Control;
            darkToolStripMenuItem.ForeColor = SystemColors.ControlText;
        }

        /// <summary>
        /// Устанавливает тёмную тему.
        /// </summary>
        public void setDarkTheme()
        {
            Color grey = Color.FromArgb(64, 64, 64);
            this.BackColor = grey;
            labelFile.BackColor = grey;
            labelFile.ForeColor = SystemColors.Control;
            msMain.BackColor = grey;
            textBoxFileText.BackColor = Color.Silver;
            listBoxTexts.BackColor = Color.Silver;
            labelCurrentFile.BackColor = grey;
            labelCurrentFile.ForeColor = SystemColors.Control;

            fileToolStripMenuItem.BackColor = grey;
            fileToolStripMenuItem.ForeColor = SystemColors.Control;
            editToolStripMenuItem.BackColor = grey;
            editToolStripMenuItem.ForeColor = SystemColors.Control;
            formatToolStripMenuItem.BackColor = grey;
            formatToolStripMenuItem.ForeColor = SystemColors.Control;
            optionsToolStripMenuItem.BackColor = grey;
            optionsToolStripMenuItem.ForeColor = SystemColors.Control;
            openNewFileToolStripMenuItem.BackColor = grey;
            openNewFileToolStripMenuItem.ForeColor = SystemColors.Control;
            openNewWindowToolStripMenuItem.BackColor = grey;
            openNewWindowToolStripMenuItem.ForeColor = SystemColors.Control;
            createNewFileToolStripMenuItem.BackColor = grey;
            createNewFileToolStripMenuItem.ForeColor = SystemColors.Control;
            createNewWindowToolStripMenuItem.BackColor = grey;
            createNewWindowToolStripMenuItem.ForeColor = SystemColors.Control;
            saveToolStripMenuItem.BackColor = grey;
            saveToolStripMenuItem.ForeColor = SystemColors.Control;
            saveAllToolStripMenuItem.BackColor = grey;
            saveAllToolStripMenuItem.ForeColor = SystemColors.Control;
            closeToolStripMenuItem.BackColor = grey;
            closeToolStripMenuItem.ForeColor = SystemColors.Control;
            fontToolStripMenuItem.BackColor = grey;
            fontToolStripMenuItem.ForeColor = SystemColors.Control;
            colorToolStripMenuItem.BackColor = grey;
            colorToolStripMenuItem.ForeColor = SystemColors.Control;
            backColorToolStripMenuItem.BackColor = grey;
            backColorToolStripMenuItem.ForeColor = SystemColors.Control;
            themeToolStripMenuItem.BackColor = grey;
            themeToolStripMenuItem.ForeColor = SystemColors.Control;
            autosaveToolStripMenuItem.BackColor = grey;
            autosaveToolStripMenuItem.ForeColor = SystemColors.Control;
            interval1ToolStripMenuItem.BackColor = grey;
            interval1ToolStripMenuItem.ForeColor = SystemColors.Control;
            interval3ToolStripMenuItem.BackColor = grey;
            interval3ToolStripMenuItem.ForeColor = SystemColors.Control;
            interval5ToolStripMenuItem.BackColor = grey;
            interval5ToolStripMenuItem.ForeColor = SystemColors.Control;
            interval10ToolStripMenuItem.BackColor = grey;
            interval10ToolStripMenuItem.ForeColor = SystemColors.Control;
            disableToolStripMenuItem.BackColor = grey;
            disableToolStripMenuItem.ForeColor = SystemColors.Control;
            lightToolStripMenuItem.BackColor = grey;
            lightToolStripMenuItem.ForeColor = SystemColors.Control;
            darkToolStripMenuItem.BackColor = grey;
            darkToolStripMenuItem.ForeColor = SystemColors.Control;
        }

        /// <summary>
        /// Опция меню "Светлая тема".
        /// Соответственно, устанавливает светлую тему.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setLightTheme();
            lightToolStripMenuItem.Checked = true;
            darkToolStripMenuItem.Checked = false;
        }

        /// <summary>
        /// Опция меню "Тёмная тема".
        /// Соответственно, устанавливает тёмную тему.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setDarkTheme();
            lightToolStripMenuItem.Checked = false;
            darkToolStripMenuItem.Checked = true;
        }

        /// <summary>
        /// После закрытия формы сохраняет настройки и формирует список файлов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            int optionAutosave;
            if (disableToolStripMenuItem.Checked)
                optionAutosave = 0;
            else if (interval1ToolStripMenuItem.Checked)
                optionAutosave = 1;
            else if (interval3ToolStripMenuItem.Checked)
                optionAutosave = 2;
            else if (interval5ToolStripMenuItem.Checked)
                optionAutosave = 3;
            else
                optionAutosave = 4;

            string options = $"{optionAutosave};{(lightToolStripMenuItem.Checked ? 0 : 1)}";
            File.WriteAllText("opt.yy", options);
            var paths = new string[files.Count];
            for (var i = 0; i < paths.Length; i++)
                paths[i] = files[i].FilePath;
            File.WriteAllLines("files.yy", paths);
        }

        /// <summary>
        /// Закрывает текущий файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                currentIndex = listBoxTexts.SelectedIndex;
                currentFile = files[currentIndex];
                if (currentFile.IsChanged)
                {
                    DialogResult result = MessageBox.Show($"В тексте {currentFile.Name} есть несохранённые изменения. Хотите их сохранить?",
                            "Несохранённые изменения", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                        WriteFile(currentFile, currentFile.Content);
                    if (result == DialogResult.Cancel)
                        return;
                }

                files.RemoveAt(currentIndex);
                textBoxFileText.Clear();
                labelCurrentFile.Text = "";
                listBoxTexts.Items.RemoveAt(currentIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не выбран элемент!");
                return;
            }
            
        }
    }
}
