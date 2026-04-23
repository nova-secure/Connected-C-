using ConnnectedProject.Controllers;
using ConnnectedProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ConnnectedProject.Views
{
    public partial class GradingForm : Form
    {
        private readonly Professor _professor;

        public GradingForm(Professor professor)
        {
            _professor = professor;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cmbStudents.Items.Clear();
            foreach (var student in DataStore.Users.OfType<Student>())
            {
                cmbStudents.Items.Add(new ComboBoxItem(student.Id, $"{student.Prenom} {student.Nom} (ID {student.Id})"));
            }

            cmbCourses.Items.Clear();
            foreach (var course in DataStore.courses.Where(c => c.IdProfesseur == _professor.Id))
            {
                cmbCourses.Items.Add(new ComboBoxItem(course.Id, $"{course.Titre} (ID {course.Id})"));
            }

            if (cmbStudents.Items.Count > 0)
                cmbStudents.SelectedIndex = 0;

            if (cmbCourses.Items.Count > 0)
                cmbCourses.SelectedIndex = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedItem is not ComboBoxItem studentItem || cmbCourses.SelectedItem is not ComboBoxItem courseItem)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant et un cours.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var controller = new ProfessorController();
            var grade = controller.GiveGrade(studentItem.Id, courseItem.Id, (double)numNote.Value);

            if (grade != null)
            {
                MessageBox.Show("Note enregistrée.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Impossible d'enregistrer la note.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private sealed class ComboBoxItem
        {
            public int Id { get; }
            public string Label { get; }

            public ComboBoxItem(int id, string label)
            {
                Id = id;
                Label = label;
            }

            public override string ToString() => Label;
        }

        private void GradingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
