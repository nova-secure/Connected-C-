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
    public class CourseDisplayDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }

    public partial class ProfessorDashboardForm : Form
    {

        private readonly Professor _professor;
        

        public ProfessorDashboardForm(Professor professor)
        {
            _professor = professor;
            Text = $"Espace Professeur - {_professor.FirstName} {_professor.LastName}";
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
            ConnnectedProject.Controllers.ProfessorController controller = new ConnnectedProject.Controllers.ProfessorController();
            //ce where  filtre les cours pour afficher que  ceux du prof connecté parceque sinon il  voit tout
            List<CourseDisplayDto> Courses = controller.GetCoursesByProfessor(_professor.Id)
                .Select(c => new CourseDisplayDto
                {
                    Id = c.Id,
                    Title = c.Title,
                    Description = c.Description,
                    Status = c.IsPublished ? "Publié" : "Brouillon"
                })
                .ToList();

            dgvCourses.DataSource = Courses;
            dgvCourses.Columns[0].HeaderText = "ID";
            dgvCourses.Columns[1].HeaderText = "Titre";
            dgvCourses.Columns[2].HeaderText = "Description";
            dgvCourses.Columns[3].HeaderText = "Publié";
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            using CourseEditorForm editor = new CourseEditorForm(_professor);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                LoadCourses();
            }
        }

        private void BtnGradeStudent_Click(object sender, EventArgs e)
        {
            ConnnectedProject.Controllers.ProfessorController controller = new ConnnectedProject.Controllers.ProfessorController();
            //verif cruciale pour pas laisser  le prof noter s'il a aucun  cours sinon ca fait un null pointer et ca crash tout
            if (!controller.GetCoursesByProfessor(_professor.Id).Any())
            {
                MessageBox.Show("Vous devez d'abord créer un cours avant de noter un étudiant.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using GradingForm grading = new GradingForm(_professor);
            if (grading.ShowDialog() == DialogResult.OK) { }
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
