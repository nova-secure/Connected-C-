using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    
    public class Student : User
    {
        public required string SchoolClass { get; set; }

        public Student(string lastName, string firstName, string email, string password) : base(lastName, firstName, email, password)
        {
            Role = global::Role.Student.ToString();
        }
    }
}

