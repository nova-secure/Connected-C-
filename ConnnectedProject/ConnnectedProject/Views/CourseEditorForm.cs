using ConnnectedProject.Controllers;
using ConnnectedProject.Models;
using System;
using System.Windows.Forms;

namespace ConnnectedProject.Views
{
    public partial class CourseEditorForm : Form
    {
        private readonly Professor _professor ;
        

        public CourseEditorForm(Professor professor)
        {
            _professor = professor;
            InitializeComponent();
        }

        public void BtnSave_Click(object sender, EventArgs e)
        {
            var titre = txtTitre.Text.Trim();
            var description = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(titre))
            {
                MessageBox.Show("Le titre du cours est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var controller = new ProfessorController();
            var course = controller.AddCourse(_professor.Id, titre, description, false);

            if (course != null)
            {
                MessageBox.Show("Le cours a bien été créé.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Impossible de créer le cours.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
