using System;

namespace ConnnectedProject.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int IdEtudiant { get; set; }
        public int IdCours { get; set; }
        public double Note { get; set; }
    }
}
