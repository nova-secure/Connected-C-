using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    internal class Admin : User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public string Role { get; set; } = Role.Admin.ToString();
    }
}
