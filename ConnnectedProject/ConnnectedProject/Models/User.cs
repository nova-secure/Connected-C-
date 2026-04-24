using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    public  class User
    {
        public int Id { get; set;} = Guid.NewGuid().GetHashCode();
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
<<<<<<< HEAD

    public User(string nom, string prenom, string email, string motDePasse)
    {
        this.Nom = nom;
        this.Prenom = prenom;
        this.Email = email;
        this.MotDePasse = motDePasse;
    }
=======
        public string Role { get; set; }

>>>>>>> 8d75320eb35c60f126908c11b9fbd20b3ddbad7f
    }
}
