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
using MyLibraryForTasks;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StripMenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Текстовые файлы (*.txt)|*.txt";
            OFD.FilterIndex = 1;
            OFD.RestoreDirectory = true;
            
                try
                {
                    if (OFD.ShowDialog() == DialogResult.OK)
                    {
                    string CheckFormatOpen = Path.GetExtension(OFD.FileName);
                    if (CheckFormatOpen == ".txt")
                    {
                        try
                        {
                            string link = OFD.FileName;
                            FileTask2 ObjectOpen = new FileTask2(link);
                            LabelAllText.Text = ObjectOpen.Open;
                            MessageBox.Show("Файл успешно добавлен на форму!");
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка чтения из файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка формата при открытии файла! Выберите формат: .txt", 
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void CreateDictionary_Click(object sender, EventArgs e)
        {
            List<string[]> dictionaryList = FileTask2.CreateDictionary(LabelAllText.Text);
            LabelDictionary.Text = FileTask2.Convert_ListArrStr_To_StrLine(dictionaryList);
        }

        private void StripMenuFile_Click(object sender, EventArgs e)
        {

        }
    }
}
