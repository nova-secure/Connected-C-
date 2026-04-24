using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace ConnnectedProject.Views
{
    public partial class CourseCatalogForm : Form
    {
        public CourseCatalogForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cours = (string)listBox1.SelectedItem;
            labelCours.Text = "Le cours choisi est : " + cours;
        }

        private void CourseCatalogForm_Load(object sender, EventArgs e)
        {

        }

        private void labelCours_Click(object sender, EventArgs e)
        {

        }
    }
}
