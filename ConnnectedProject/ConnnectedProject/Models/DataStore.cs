using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConnnectedProject.Models
{
    internal static class DataStore
    {
        public static List<User> Users = new List<User>();

        public static void DataInitialize()
        {
            // Default Admin
            Users.Add(new Admin { Id = 1, Nom = "Boss", Prenom = "Le", Email = "admin@test.com", MotDePasse = "1234", Role = "Admin" });

            // Default Teacher
            Users.Add(new Professor { Id = 2, Nom = "Einstein", Prenom = "Albert", Email = "prof@test.com", MotDePasse = "1234", Role = "Professor" });

            // Default Student
            Users.Add(new Student { Id = 3, Nom = "Dupont", Prenom = "Jean", Email = "eleve@test.com", MotDePasse = "1234", Role = "Student", Classe = "A" });
        } 
    }
}
