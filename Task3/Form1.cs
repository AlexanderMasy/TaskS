using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibraryForTasks;
using MyLibraryForTasks.ForTask3;
using MyLibraryForTasks.ForTask3.Planes;
using System.IO;

namespace Task3
{
    public partial class Form1 : Form
    {
        List<PassengerPlane> allPassengerPlanes;
        List<CargoPlane> allCargoPlanes;
        public Form1()
        {
            InitializeComponent();
            //allCargoPlanes = new List<CargoPlane> { };
            //allPassengerPlanes = new List<PassengerPlane> { };
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Текстовые файлы (*.txt)|*.txt";
            OFD.FilterIndex = 1;
            OFD.RestoreDirectory = true;

            int CountEror = 0;
            try
            {
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    string CheckFormatOpen = Path.GetExtension(OFD.FileName);
                    if (CheckFormatOpen == ".txt")
                    {
                        try
                        {
                            allCargoPlanes = new List<CargoPlane> { };
                            allPassengerPlanes = new List<PassengerPlane> { };
                            label1.Text = "";
                            string link = OFD.FileName;
                            FileTask2 ObjectOpen = new FileTask2(link);
                            List<string> arrayLines = ObjectOpen.Open.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                            foreach (string line in arrayLines)
                            {
                                if (line != "\r" && line != "\n") 
                                {
                                    List<string> propertyPlane = line.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                                    if (propertyPlane[0] == "Passenger")
                                    {
                                        PassengerPlane newPassengerPlane = new PassengerPlane(propertyPlane[1], Convert.ToInt32(propertyPlane[2]), propertyPlane[3],
                                            Convert.ToInt32(propertyPlane[4]), Convert.ToInt32(propertyPlane[5]), Convert.ToInt32(propertyPlane[6]));
                                        allPassengerPlanes.Add(newPassengerPlane);
                                        CountEror++;
                                    }
                                    else
                                    {
                                        CargoPlane newCargoPlane = new CargoPlane(propertyPlane[1], Convert.ToInt32(propertyPlane[2]), propertyPlane[3],
                                            Convert.ToInt32(propertyPlane[4]), Convert.ToInt32(propertyPlane[6]));
                                        allCargoPlanes.Add(newCargoPlane);
                                        CountEror++;
                                    }
                                }
                            }
                            label1.Text+=SortFor3Task.ConvertTwoArrToLineStr(allPassengerPlanes, allCargoPlanes);
                            MessageBox.Show("Файл успешно добавлен на форму!");
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка чтения из файла"+Convert.ToString(CountEror), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxCapacity.Checked)
            {
                label2.Text += Convert.ToString(SortFor3Task.CapacityOfAllPlane(allPassengerPlanes)) + " мест.\n";
            }
            else
            {
                if (checkBoxCarrying.Checked)
                {
                    label2.Text += Convert.ToString(SortFor3Task.CarryingOfAllPlane(allCargoPlanes)) + " КГ.\n";
                }
                else
                {
                    label2.Text += SortFor3Task.ConvertArrPlanesToLineStr(SortFor3Task.SortPlanes(SortFor3Task.ConnectionOfArrays(allCargoPlanes, allPassengerPlanes)));
                }
            }
        }

        private void checkBoxSortForRange_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCapacity.Checked = false;
            checkBoxCarrying.Checked = false;
        }

        private void checkBoxCapacity_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCarrying.Checked = false;
            checkBoxSortForRange.Checked = false;
        }

        private void checkBoxCarrying_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSortForRange.Checked = false;
            checkBoxCapacity.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
