using ConnnectedProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnnectedProject.Controllers
{
    internal class AdminController
    {
        public List<Professor> GetProfessors()
        {
            return DataStore.Users.OfType<Professor>().ToList();
        }

        public List<Student> GetStudents()
        {
            return DataStore.Users.OfType<Student>().ToList();
        }

        
        //compte le nombre d'étudiants pour les stats  du tableau de  bord grace a  linq
        public int CountStudents()
        {
            return DataStore.Users.OfType<Student>().Count();
        }

        public List<User> GetAllUsers()
        {
            return DataStore.Users.ToList();
        }

        public User CreateUser(string lastName, string firstName, string email, string password, string role, string? schoolClass = null)
        {
            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(role))
                return null;

            if (EmailExists(email))
                return null;

            //le switch sert a instancier la  bonne classe derivée parceque User c'est  une class abstract donc pas  de new User() possible
            User user;
            switch (role)
            {
                case "Admin":
                    user = new Admin(lastName.Trim(), firstName.Trim(), email.Trim(), password);
                    break;
                case "Professor":
                    user = new Professor(lastName.Trim(), firstName.Trim(), email.Trim(), password);
                    break;
                case "Student":
                    if (string.IsNullOrWhiteSpace(schoolClass))
                        return null;
                    user = new Student(lastName.Trim(), firstName.Trim(), email.Trim(), password)
                    {
                        SchoolClass = schoolClass.Trim()
                    };
                    break;
                default:
                    return null;
            }

            DataStore.Users.Add(user);
            return user;
        }

        public bool UpdateUser(int id, string lastName, string firstName, string email, string password, string role, string? schoolClass = null)
        {
            User? user = DataStore.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return false;

            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(role))
                return false;

            if (EmailExists(email, id))
                return false;

            //ce boolean verifie si le role a  changé, si oui on doit  recreer l'objet sinon on modifie juste le  nom et on garde le meme id
            bool roleUnchanged = user.Role.Equals(role, StringComparison.OrdinalIgnoreCase);
            if (roleUnchanged)
            {
                user.LastName = lastName.Trim();
                user.FirstName = firstName.Trim();
                user.Email = email.Trim();
                user.Password = password;

                if (user is Student student)
                {
                    student.SchoolClass = schoolClass?.Trim() ?? string.Empty;
                }

                return true;
            }

            User newUser;
            switch (role)
            {
                case "Admin":
                    newUser = new Admin(lastName.Trim(), firstName.Trim(), email.Trim(), password);
                    break;
                case "Professor":
                    newUser = new Professor(lastName.Trim(), firstName.Trim(), email.Trim(), password);
                    break;
                case "Student":
                    if (string.IsNullOrWhiteSpace(schoolClass))
                        return false;
                    newUser = new Student(lastName.Trim(), firstName.Trim(), email.Trim(), password)
                    {
                        SchoolClass = schoolClass.Trim()
                    };
                    break;
                default:
                    return false;
            }

            newUser.Id = user.Id;
            DataStore.Users.Remove(user);
            DataStore.Users.Add(newUser);
            return true;
        }

        public User GetUser(int id)
        {
            return DataStore.Users.FirstOrDefault(u => u.Id == id);
        }

        public bool DeleteUser(int id)
        {
            User? user = DataStore.Users.FirstOrDefault(u => u.Id == id && !(u is Admin));
            if (user == null)
                return false;

            DataStore.Users.Remove(user);
            return true;
        }

        private bool EmailExists(string email, int? ignoreId = null)
        {
            return DataStore.Users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                && (!ignoreId.HasValue || u.Id != ignoreId.Value));
        }
    }
}
