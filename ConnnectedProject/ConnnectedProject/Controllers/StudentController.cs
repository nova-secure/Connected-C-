/*
using ConnnectedProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
                if (e.EstPublié == true)
                {
                    coursPubliés.Add(e);
                }
            }
        }
        public class Bulletin : User
        {
            bool ConnecterOuPas = (DataStore in Student.Id);
            int[] MoyenneNote = { Grade };

            double Moy = MoyenneNote.Average();

        }
    }

}
/*