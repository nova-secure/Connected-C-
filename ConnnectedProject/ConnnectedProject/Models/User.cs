using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    
    public abstract class User(string lastName, string firstName, string email, string password)
    {
        public int Id { get; set; } = Math.Abs(Guid.NewGuid().GetHashCode());
        public string LastName { get; set; } = lastName;
        public string FirstName { get; set; } = firstName;
        public string Email { get; set; } = email;
        public string Password { get; set; } = password;
        public string Role { get; protected set; } = string.Empty;
    }
}
