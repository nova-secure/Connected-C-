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

            Courses course = new Courses 
            {
                Id = DataStore.NextCourseId++,
                Title = titre.Trim(),
                Description = description?.Trim() ?? string.Empty,
                ProfessorId = idProfesseur,
                IsPublished = estPublie
            };

            
            DataStore.Courses.Add(course);
            return course;
        }

        public Grade GiveGrade(int idEtudiant, int idCours, double note)
        {
            if (note < 0 || note > 20)
                return null;

            Student? student = DataStore.Users.OfType<Student>().FirstOrDefault(s => s.Id == idEtudiant); 
            Courses? course = DataStore.Courses.FirstOrDefault(c => c.Id == idCours); 

            if (student == null || course == null)
                return null;

            Grade grade = new Grade
            {
                Id = DataStore.NextGradeId++,
                StudentId = idEtudiant,
                CourseId = idCours,
                Score = note
            };

            DataStore.Grades.Add(grade);
            return grade;
        }

        public System.Collections.Generic.List<Student> GetAllStudents()
        {
            return DataStore.Users.OfType<Student>().ToList();
        }

        public System.Collections.Generic.List<Courses> GetCoursesByProfessor(int professorId)
        {
            return DataStore.Courses.Where(c => c.ProfessorId == professorId).ToList();
        }
    }
}
