using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    public class Admin : User
    {
//HEAD
        public Role role = Role.Admin;
    public Admin(string nom, string prenom, string email, string motDePasse) : base(nom, prenom, email, motDePasse)
        {
            nom = this.Nom;
            prenom = this.Prenom;
            email = this.Email;
            motDePasse = this.MotDePasse;
        }
//

    public Admin(string nom, string prenom, string email, string motDePasse) : base(Nom, Prenom, Email, MotDePasse)      
    {
           this.Role = Role.Admin.ToString();
    }
// 8d75320eb35c60f126908c11b9fbd20b3ddbad7f
    }
}
