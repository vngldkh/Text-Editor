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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            sfdNewFile.Filter = "Текстовый файл(*.txt)|*.txt|Файл rtf(*.rtf)|*.rtf|Все файлы(*.*)|*.*";
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ofdChooseFile.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
                var fef = new FormEditFile(ofdChooseFile.FileName, false);
                fef.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Упс! Непредвиденная ошибка!\n{ex.Message}");
            }
        }

        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                var result = sfdNewFile.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
                File.WriteAllText(sfdNewFile.FileName, "");
                var fef = new FormEditFile(sfdNewFile.FileName, false);
                fef.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Упс! Непредвиденная ошибка!\n{ex.Message}");
            }
        }

        private void buttonopenEarlier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("files.yy") || File.ReadAllText("files.yy") == "")
                {
                    MessageBox.Show("Нет ранее закрытых файлов!");
                    return;
                }
                var fef = new FormEditFile("", true);
                fef.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Упс! Непредвиденная ошибка!\n{ex.Message}");
            }
        }
    }
}
