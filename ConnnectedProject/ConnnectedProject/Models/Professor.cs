using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    public class Professor : User
    {
        public string role = Role.Professor.ToString();
        public List<string> Classes = [] ;
        public Professor(string nom, string prenom, string email, string motDePasse) : base(nom, prenom, email, motDePasse)
        {
            nom = this.Nom;
            prenom = this.Prenom;
            email = this.Email;
            motDePasse = this.MotDePasse;
        }
    }
}

