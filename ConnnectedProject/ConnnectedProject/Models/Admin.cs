using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    public class Admin : User
    {
        public Admin(string nom, string prenom, string email, string motDePasse) : base(nom, prenom, email, motDePasse)
        {
            Role = global::Role.Admin.ToString();
        }
    }
}
