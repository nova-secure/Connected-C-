
using ConnnectedProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConnnectedProject.Controllers
{
    internal class StudentController
    {
        public List<Courses> CoursQuiSontPublié()
        {
            List<Courses> coursPubliés = new List<Courses>();

            
            foreach (Courses e in DataStore.Courses)
            {
                if (e.IsPublished == true) //Si je coche "Publier"
                {
                    coursPubliés.Add(e); //Le cours est ajouté
                }
            }
            return coursPubliés;
        }

        public double Bulletin(int IdStudent)
        {
            List<Grade> notesEtudiant = DataStore.Grades.Where(g => g.StudentId == IdStudent).ToList();
            if (notesEtudiant.Count == 0)
            {
                return 0;
            }

            double moyenne = notesEtudiant.Average(g => g.Score);
            return moyenne;
        }

        public List<GradeDetail> GetDetailedGrades(int studentId)
        {
            return DataStore.Grades.Where(g => g.StudentId == studentId).Join(DataStore.Courses, grade => grade.CourseId, cours => cours.Id, (grade, cours) => new GradeDetail { Matière = cours.Title, Score = grade.Score }).ToList();
        }
    }

    public class GradeDetail
    {
        public string Matière { get; set; }
        public double Score { get; set; }
    }
}