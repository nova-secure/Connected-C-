using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
    internal class Course
    {
            public int Id { get; set; }
            public string Titre { get; set; }
            public string Description { get; set; }
            public int IdProfesseur { get; set; }
            public bool EstPublie { get; set; }
    }
}
