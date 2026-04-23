using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConnnectedProject.Models
{
    public  class DataStore
    {

        public static List<User> Users = new List<User>();
        public static List<Courses> courses = new List<Courses>();
        public static List<Grade> Grades = new List<Grade>();
        public static int NextCourseId = 1;
        public static int NextGradeId = 1;

        public  void DataInitialize()
        {
            // Default Admin
            Users.Add(new Admin { Nom = "Boss", Prenom = "Le", Email = "admin@test.com", MotDePasse = "1234" });

            // Default Teacher
            Users.Add(new Professor { Nom = "Einstein", Prenom = "Albert", Email = "prof@test.com", MotDePasse = "1234" });

            // Default Student
            Users.Add(new Student { Nom = "Dupont", Prenom = "Jean", Email = "eleve@test.com", MotDePasse = "1234"});


        } 
    }
}
