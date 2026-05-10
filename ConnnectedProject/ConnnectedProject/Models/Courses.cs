using System;
using System.Collections.Generic;
using System.Text;

namespace ConnnectedProject.Models
{
public class Courses
    {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public int ProfessorId { get; set; }
            public bool IsPublished { get; set; }
    }
}
