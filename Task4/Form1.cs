using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibraryForTasks.ForTask4;
using System.IO;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonClearCalculatData_Click(object sender, EventArgs e)
        {
            labelDirectorData.Text = "";
            labelSubsidiaryData.Text = "";
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            try
            {
                Subsidiary sameObject = new Subsidiary(textBoxSurname.Text, Convert.ToInt32(textBoxSelfAssessment.Text),
                    Convert.ToInt32(textBoxEvaluationOfPeople.Text), Convert.ToInt32(textBoxEvaluationByDescendants.Text));
                Director otherObject = new Director(textBoxSurname.Text, Convert.ToInt32(textBoxSelfAssessment.Text),
                    Convert.ToInt32(textBoxEvaluationOfPeople.Text));
                labelDirectorData.Text += sameObject.Surname +" Q=" + Convert.ToString(otherObject.Calculator())+"\n";
                labelSubsidiaryData.Text += otherObject.Surname + " Qp=" + Convert.ToString(sameObject.Calculator()) + "\n";
            }
            catch
            {
                MessageBox.Show("Ошибка ввода! Попробуйте ещё раз.");
            }
        }
    }
}
