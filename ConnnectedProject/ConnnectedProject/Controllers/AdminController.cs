using ConnnectedProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Controllers
{
	internal class AdminController 
	{
//récupère les données de la classe DataStore
		DataStore data = new DataStore();
//Affiche la liste des professeurs
		public void AfficherProfesseur(){
			Console.WriteLine(data.GetProfesseurs);
		}
//Création d'un nouveau professeur et l'ajoute dans la liste des professeurs
		public void CreerNouveauProfesseur(){
			Professor prof = new Professor();
            prof.Id = Guid.NewGuid();
            data.GetProfesseurs.Add(prof);
		}
	
//Affiche la liste des étudiants
        public void AfficherEtudiant(){
            Console.WriteLine(data.GetEtudiants);
        }
    }
}
