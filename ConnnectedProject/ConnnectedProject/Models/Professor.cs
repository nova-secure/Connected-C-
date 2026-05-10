using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    public class Professor : User
    {
        public List<string> Classes { get; set; } = new List<string>();

        public Professor(string lastName, string firstName, string email, string password) : base(lastName, firstName, email, password)
        {
            Role = global::Role.Professor.ToString();
        }
    }
}

