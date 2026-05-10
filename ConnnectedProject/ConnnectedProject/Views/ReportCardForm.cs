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

        
        public ReportCardForm(Models.Student student)
        {
            _student = student;
            InitializeComponent();

            ConnnectedProject.Controllers.StudentController ctrl = new ConnnectedProject.Controllers.StudentController();
            double moyene = ctrl.Bulletin(_student.Id);

            
            label1.Text = "Ta moyenne est de " + moyene.ToString("0.00") + " !";

            DataGridView dgvNotes = new DataGridView
            {
                Top = 50, 
                Left = 50, 
                Width = 600,
                Height = 450,
             };
                List<ConnnectedProject.Controllers.GradeDetail> detailNotes = ctrl.GetDetailedGrades(_student.Id);

                dgvNotes.DataSource = detailNotes;
                this.Controls.Add(dgvNotes);
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
