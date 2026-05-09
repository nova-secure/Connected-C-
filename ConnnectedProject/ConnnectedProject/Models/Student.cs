using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    internal class Student : User
    {
        public required string Classe { get; set; }

        public Student(string nom, string prenom, string email, string motDePasse) : base(nom, prenom, email, motDePasse)
        {
            Role = global::Role.Student.ToString();
        }
    }
}

