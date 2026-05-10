
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

            //j'ai corrigé la cas pour  ciblé  la bonne variabl Courses
            foreach (Courses e in DataStore.Courses)
            {
                if (e.EstPublie == true)
                {
                    coursPubliés.Add(e);
                }
            }
            return coursPubliés;
        }

        public double Bulletin(int IdStudent)
        {
            var notesEtudiant = DataStore.Grades.Where(g => g.IdEtudiant == IdStudent).ToList();
            if (notesEtudiant.Count == 0)
            {
                return 0;
            }

            double moyenne = notesEtudiant.Average(g => g.Note);
            return moyenne;
        }
    }
}