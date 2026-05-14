using System;
using System.Collections.Generic;
using ConnnectedProject.Models;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace ConnnectedProject.Views
{
    public partial class  CourseCatalogForm : Form
    {
        private ConnnectedProject.Controllers.StudentController _controller = new ConnnectedProject.Controllers.StudentController();

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
            
            List<Courses> listeCours = _controller.CoursQuiSontPublié();
            listBox1.Items.Clear();
  
            foreach (Courses c in listeCours)
            {
                listBox1.Items.Add(c.Title);
            }
        }

        private void labelCours_Click(object sender, EventArgs e)
        {

        }
    }
}
