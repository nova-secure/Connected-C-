using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConnnectedProject.Views
{
    public partial class StudentDashboardForm : Form
    {
        public StudentDashboardForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CourseCatalogForm Cours = new CourseCatalogForm();
            this.Hide();
            Cours.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm checkPoints = new LoginForm();
            this.Hide();
            checkPoints.ShowDialog();
        }
    }
}
