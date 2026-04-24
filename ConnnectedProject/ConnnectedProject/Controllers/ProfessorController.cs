using ConnnectedProject.Models;
using System;
using System.Linq;

namespace ConnnectedProject.Controllers
{
    internal class ProfessorController
    {
        public Courses AddCourse(int idProfesseur, string titre, string description, bool estPublie = false)
        {
            if (string.IsNullOrWhiteSpace(titre))
                return null;

            var course = new Courses // var ici vaut Course, le compilateur peut le d�duire � partir de l'initialisation je me fou de hahaha
            {
                Id = DataStore.NextCourseId++,
                Titre = titre.Trim(),
                Description = description?.Trim() ?? string.Empty,
                IdProfesseur = idProfesseur,
                EstPublie = estPublie
            };

            DataStore.courses.Add(course);
            return course;
        }

        public Grade GiveGrade(int idEtudiant, int idCours, double note)
        {
            if (note < 0 || note > 20)
                return null;

            var student = DataStore.Users.OfType<Student>().FirstOrDefault(s => s.Id == idEtudiant); //On v�rifie que l'�tudiant existe et est bien un �tudiant
            var course = DataStore.courses.FirstOrDefault(c => c.Id == idCours); // pareil pour le cours

            if (student == null || course == null)
                return null;

            var grade = new Grade
            {
                Id = DataStore.NextGradeId++,
                IdEtudiant = idEtudiant,
                IdCours = idCours,
                Note = note
            };

            DataStore.Grades.Add(grade);
            return grade;
        }

        public bool IsPublished()
        {
            // pour rendre visible le cour au etudiant
            return false;
        }
    }
}

