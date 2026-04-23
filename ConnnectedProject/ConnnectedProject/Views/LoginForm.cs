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
                    // new AdminDashboardForm().Show();  Zoubair
                    MessageBox.Show("Ouverture du Dashboard de Zoubair (Admin)");
                }
                else if (userConnecte.Role == "Professeur")
                {
                    // new ProfessorDashboardForm().Show(); Lorenzo
                    MessageBox.Show("Ouverture du Dashboard de Lorenzo (Prof)");
                }
                else if (userConnecte.Role == "Etudiant")
                {
                    // new StudentDashboardForm().Show(); Thibaut
                    MessageBox.Show("Ouverture du Dashboard de Thibaut (Étudiant)");
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
