using ConnnectedProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnnectedProject.Controllers
{
    internal class AdminController
    {
        public List<Professor> AfficherProfesseurs()
        {
            return DataStore.Users.OfType<Professor>().ToList();
        }

        public List<Student> AfficherEtudiants()
        {
            return DataStore.Users.OfType<Student>().ToList();
        }

        public List<User> AfficherTousLesUtilisateurs()
        {
            return DataStore.Users.ToList();
        }

        public User CreerUtilisateur(string nom, string prenom, string email, string motDePasse, string role, string? classe = null)
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(motDePasse) ||
                string.IsNullOrWhiteSpace(role))
                return null;

            if (EmailExiste(email))
                return null;

            User utilisateur;
            switch (role)
            {
                case "Admin":
                    utilisateur = new Admin(nom.Trim(), prenom.Trim(), email.Trim(), motDePasse);
                    break;
                case "Professor":
                    utilisateur = new Professor(nom.Trim(), prenom.Trim(), email.Trim(), motDePasse);
                    break;
                case "Student":
                    if (string.IsNullOrWhiteSpace(classe))
                        return null;
                    utilisateur = new Student(nom.Trim(), prenom.Trim(), email.Trim(), motDePasse)
                    {
                        Classe = classe.Trim()
                    };
                    break;
                default:
                    return null;
            }

            DataStore.Users.Add(utilisateur);
            return utilisateur;
        }

        public bool ModifierUtilisateur(int id, string nom, string prenom, string email, string motDePasse, string role, string? classe = null)
        {
            var utilisateur = DataStore.Users.FirstOrDefault(u => u.Id == id);
            if (utilisateur == null)
                return false;

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(role))
                return false;

            if (EmailExiste(email, id))
                return false;

            var roleInchange = utilisateur.Role.Equals(role, StringComparison.OrdinalIgnoreCase);
            if (roleInchange)
            {
                utilisateur.Nom = nom.Trim();
                utilisateur.Prenom = prenom.Trim();
                utilisateur.Email = email.Trim();
                utilisateur.MotDePasse = motDePasse;

                if (utilisateur is Student student)
                {
                    student.Classe = classe?.Trim() ?? string.Empty;
                }

                return true;
            }

            User nouveau;
            switch (role)
            {
                case "Admin":
                    nouveau = new Admin(nom.Trim(), prenom.Trim(), email.Trim(), motDePasse);
                    break;
                case "Professor":
                    nouveau = new Professor(nom.Trim(), prenom.Trim(), email.Trim(), motDePasse);
                    break;
                case "Student":
                    if (string.IsNullOrWhiteSpace(classe))
                        return false;
                    nouveau = new Student(nom.Trim(), prenom.Trim(), email.Trim(), motDePasse)
                    {
                        Classe = classe.Trim()
                    };
                    break;
                default:
                    return false;
            }

            nouveau.Id = utilisateur.Id;
            DataStore.Users.Remove(utilisateur);
            DataStore.Users.Add(nouveau);
            return true;
        }

        public User ObtenirUtilisateur(int id)
        {
            return DataStore.Users.FirstOrDefault(u => u.Id == id);
        }

        public bool SupprimerUtilisateur(int id)
        {
            var utilisateur = DataStore.Users.FirstOrDefault(u => u.Id == id && !(u is Admin));
            if (utilisateur == null)
                return false;

            DataStore.Users.Remove(utilisateur);
            return true;
        }

        private bool EmailExiste(string email, int? ignoreId = null)
        {
            return DataStore.Users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                && (!ignoreId.HasValue || u.Id != ignoreId.Value));
        }
    }
}
