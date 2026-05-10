using ConnnectedProject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ConnnectedProject.Models; 
namespace ConnnectedProject.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            AuthController auth = new AuthController();

            User userConnecte = auth.Authentication(txtEmail.Text, txtMdp.Text);

            if (userConnecte != null)
            {
                if (userConnecte.Role == "Admin")
                {
                    PanelController adminPanel = new PanelController();
                    adminPanel.FormClosed += (s, args) => this.Show();
                    adminPanel.Show();
                    this.Hide();
                }
                else if (userConnecte.Role == "Professor" || userConnecte.Role == "Professeur")
                {
                    ProfessorDashboardForm profDashboard = new ProfessorDashboardForm((Professor)userConnecte);
                    profDashboard.FormClosed += (s, args) => this.Show();
                    profDashboard.Show();
                    this.Hide();
                }
                else if (userConnecte.Role == "Student" || userConnecte.Role == "Etudiant")
                {
                    Student etu = userConnecte as Student;
                    StudentDashboardForm f = new StudentDashboardForm(etu);
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Email ou mot de passe incorrect !");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
