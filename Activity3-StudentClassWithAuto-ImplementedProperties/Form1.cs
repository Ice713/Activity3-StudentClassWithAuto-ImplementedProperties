using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity3_StudentClassWithAuto_ImplementedProperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                GPA = double.Parse(numericUpDownGPA.Text)
            };

            MessageBox.Show($"Student: {student.FirstName} {student.LastName}\nGPA: {student.GPA}");
        }
    }
}
