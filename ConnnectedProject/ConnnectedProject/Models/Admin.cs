using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    internal class Admin : User
    {

    public Admin(string nom, string prenom, string email, string motDePasse) : base(Nom, Prenom, Email, MotDePasse)      
    {
             this.Role = Role.Admin.ToString();
    }
    }


}
