using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConnnectedProject.Views
{
    public partial class ReportCardForm : Form
    {
        private Models.Student _student;

        //j'ai mit  l'etudian on  paramtr pour calcluer la  moyene
        public ReportCardForm(Models.Student student)
        {
            _student = student;
            InitializeComponent();
            var ctrl = new ConnnectedProject.Controllers.StudentController();
            double moyene = ctrl.Bulletin(_student.Id);
            //jafiche la moyenn  sur le label
            label1.Text = "Ta moyenne est de " + moyene.ToString("0.00") + " !";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
