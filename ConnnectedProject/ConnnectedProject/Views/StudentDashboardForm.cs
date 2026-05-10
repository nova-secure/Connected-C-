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
        private Models.Student _student;

        // Ancienne ligne : public StudentDashboardForm()
        // Explication : Salut, j'ai ajouté l'étudiant en paramètre pour pouvoir l'utiliser dans ce dashboard et éviter le crash à la compilation.
        public StudentDashboardForm(Models.Student student)
        {
            _student = student;
            InitializeComponent();
            this.Text = "Bienvenue AKHY ! - " + _student.Prenom;


            // Explication : Salut, j'ai ajouté un bouton par le code pour permettre à l'étudiant d'aller voir son bulletin, car ça manquait.
            Button btnBulletin = new Button();
            btnBulletin.Text = "Voir mon Bulletin";
            btnBulletin.Top = 150;
            btnBulletin.Left = 50;
            btnBulletin.Width = 150;
            btnBulletin.Click += (s, e) =>
            {
                var f = new ReportCardForm(_student);
                f.Show();
            };
            this.Controls.Add(btnBulletin);
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportCardForm Cours = new ReportCardForm(_student);
            this.Hide();
            Cours.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseCatalogForm checkPoints = new CourseCatalogForm();
            this.Hide();
            checkPoints.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm checkPoints = new LoginForm();
          
            checkPoints.ShowDialog();
            this.Close();
        }
    }
}
