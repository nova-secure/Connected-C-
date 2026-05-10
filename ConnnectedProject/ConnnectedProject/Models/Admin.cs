using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    public class Admin : User
    {
        public Admin(string lastName, string firstName, string email, string password) : base(lastName, firstName, email, password)
        {
            Role = global::Role.Admin.ToString();
        }
    }
}
