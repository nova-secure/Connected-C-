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
            Users.Add(new Admin("Boss", "Le", "admin@test.com", "1234"));

            // Default Teacher
            Users.Add(new Professor("Einstein", "Albert", "prof@test.com", "1234"));

            // Default Student
            Users.Add(new Student("Dupont", "Jean", "eleve@test.com", "1234") { Classe = "A" });


        } 
    }
}
