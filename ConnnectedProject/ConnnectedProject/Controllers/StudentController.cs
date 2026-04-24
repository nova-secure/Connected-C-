
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

            foreach (Courses e in DataStore.courses)
            {
                if (e.EstPublie == true)
                {
                    coursPubliés.Add(e);
                }
            }
            return coursPubliés;
        }

        public void Bulletin()
        {
           // bool ConnecterOuPas = (DataStore in Student.Id;
            //int[] MoyenneNote = { Grade };

            //double Moy = MoyenneNote.Average();
        }

    }


}
