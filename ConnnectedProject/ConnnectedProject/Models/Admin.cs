using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    internal class Admin : User
    {
        public Role role = Role.Admin;
    public Admin(string nom, string prenom, string email, string motDePasse) : base(nom, prenom, email, motDePasse)
        {
            nom = this.Nom;
            prenom = this.Prenom;
            email = this.Email;
            motDePasse = this.MotDePasse;
        }
    }


}
