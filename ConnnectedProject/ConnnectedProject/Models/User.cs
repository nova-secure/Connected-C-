using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    public  class User(string nom, string prenom, string email, string motDePasse)
    {
        public int Id { get; private set;} = Guid.NewGuid().GetHashCode();
        public string Nom { get; set; } = nom;
        public string Prenom { get; set; } = prenom;
        public string Email { get; set; } = email;
        public string MotDePasse { get; set; } = motDePasse;
    }
}
