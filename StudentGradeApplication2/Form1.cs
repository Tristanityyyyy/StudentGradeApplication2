using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication2
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double gradenum1 = Convert.ToDouble(textBox2.Text);
            double gradenum2 = Convert.ToDouble(textBox3.Text);
            double gradenum3 = Convert.ToDouble(textBox4.Text);
            double gradenum4 = Convert.ToDouble(textBox5.Text);
            double gradenum5 = Convert.ToDouble(textBox6.Text);

            double sum =  gradenum1 + gradenum2 + gradenum3 + gradenum4 + gradenum5;
            double gradeAve = sum / 5;

            string result = gradeAve >= 75.00 ? "                   The student passed. \n The general average of " + name + " is " + gradeAve : "                  The student failed. n The general average of " + name + " is " + gradeAve ;
            
            label8.Text = result;
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
