using ConnnectedProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConnnectedProject.Views
{
    public partial class ProfessorDashboardForm : Form
    {

        private readonly Professor _professor;
        

        public ProfessorDashboardForm(Professor professor)
        {
            _professor = professor;
            Text = $"Espace Professeur - {_professor.Prenom} {_professor.Nom}";
            Width = 800;
            Height = 520;
            StartPosition = FormStartPosition.CenterScreen;

            dgvCourses = new DataGridView
            {
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Dock = DockStyle.Top,
                Height = 360
            };

            btnAddCourse = new Button
            {
                Text = "Créer un cours",
                Width = 180,
                Top = 380,
                Left = 20
            };
            btnAddCourse.Click += BtnAddCourse_Click;

            btnGradeStudent = new Button
            {
                Text = "Noter un étudiant",
                Width = 180,
                Top = 380,
                Left = 220
            };
            btnGradeStudent.Click += BtnGradeStudent_Click;

            btnRefresh = new Button
            {
                Text = "Actualiser",
                Width = 120,
                Top = 380,
                Left = 420
            };
            btnRefresh.Click += BtnRefresh_Click;

            Controls.Add(dgvCourses);
            Controls.Add(btnAddCourse);
            Controls.Add(btnGradeStudent);
            Controls.Add(btnRefresh);

            LoadCourses();
        }

        private void LoadCourses()
        {
            var courses = DataStore.Courses
                .Where(c => c.IdProfesseur == _professor.Id)
                .Select(c => new
                {
                    c.Id,
                    c.Titre,
                    c.Description,
                    EstPubli = c.EstPublie ? "Oui" : "Non"
                })
                .ToList();

            dgvCourses.DataSource = courses;
            dgvCourses.Columns[0].HeaderText = "ID";
            dgvCourses.Columns[1].HeaderText = "Titre";
            dgvCourses.Columns[2].HeaderText = "Description";
            dgvCourses.Columns[3].HeaderText = "Publié";
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            using var editor = new CourseEditorForm(_professor);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadCourses();
            }
        }

        private void BtnGradeStudent_Click(object sender, EventArgs e)
        {
            if (!DataStore.Courses.Any(c => c.IdProfesseur == _professor.Id))
            {
                MessageBox.Show("Vous devez d'abord créer un cours avant de noter un étudiant.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var grading = new GradingForm(_professor);
            grading.ShowDialog();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void prof_Load(object sender, EventArgs e)
        {

        }
    }
}
