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
            string titre = txtTitre.Text;
            string description = txtDescription.Text;

            if (titre == "")
            {
                MessageBox.Show("Le titre du cours est obligatoire.");
                return;
            }

            // On regarde si la case est cochée
            bool estPublie = false;
            if (checkBoxPublie.Checked == true)
            {
                estPublie = true;
            }

            ProfessorController controller = new ProfessorController();
            // On utilise la variable estPublie au lieu de false
            Courses course = controller.AddCourse(_professor.Id, titre, description, estPublie);

            if (course != null)
            {
                MessageBox.Show("Le cours a bien été créé.");
                this.Close();
            }
        }
    }
}
