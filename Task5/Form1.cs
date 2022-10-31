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
using MyLibraryForTasks.ForTask5;

namespace Task5
{
    public partial class Form1 : Form
    {
        List<TypeOfSport> allTeamFootball = new List<TypeOfSport> { };
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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
                            Utils objectOpen = new Utils(OFD.FileName);
                            List<string[]> listTeamFootball = objectOpen.SplitParagraphsByTAB(objectOpen.SplitByParagraphs(objectOpen.Open));
                            foreach(string[] item in listTeamFootball)
                            {
                                //Football team = new Football(item[0], item[1]);
                                allTeamFootball.Add(new Football(item[0], item[1]));
                            }
                            DataOutput(allTeamFootball);
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка считывания файла! Возможно файл повреждён");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка формата при открытии файла! Выберите формат: .txt",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataOutput(List<TypeOfSport> list)
        {
            labelData.Text += list[0].SportName+":\n";
            foreach (TypeOfSport item in list)
            {
                Random rnd = new Random();
                Football definingTypeOfSportForItem = item as Football;
                if(definingTypeOfSportForItem is Football)
                {
                    int coefficient = rnd.Next(20);
                    labelData.Text += "     "+definingTypeOfSportForItem.NameTeam + "\t    Коэффициент:"+ coefficient + "         " +definingTypeOfSportForItem.Сhant()+"\n";
                }
            }
        }
    }
}
