using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    public class Professor : User
    {
        public List<string> Classes { get; set; } = new List<string>();

        public Professor(string nom, string prenom, string email, string motDePasse) : base(nom, prenom, email, motDePasse)
        {
            Role = global::Role.Professor.ToString();
        }
    }
}

