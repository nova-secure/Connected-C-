using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConnnectedProject.Models
{
    public static class DataStore
    {

        public static List<User> Users = new List<User>();
        public static List<Courses> Courses = new List<Courses>();
        public static List<Grade> Grades = new List<Grade>();
        public static int NextCourseId = 1;
        public static int NextGradeId = 1;

        //cette fonction  crée des données de demo pour  la soutenance, avec  des vrais noms et  des notes pour tester le dashboard etudiant mdr
        public static void InitializeData()
        {
            // --- ADMINISTRATEURS ---
            Users.Add(new Admin("Dupont", "Marie", "admin@school.com", "admin123"));
            Users.Add(new Admin("Morel", "Jacques", "j.morel@school.com", "admin123"));

            // --- PROFESSEURS ---
            Professor profMath = new Professor("Turing", "Alan", "alan.turing@school.com", "prof123");
            Professor profPhysique = new Professor("Curie", "Marie", "marie.curie@school.com", "prof123");
            Professor profInfo = new Professor("Lovelace", "Ada", "ada.lovelace@school.com", "prof123");
            
            Users.Add(profMath);
            Users.Add(profPhysique);
            Users.Add(profInfo);

            // --- ÉTUDIANTS ---
            Student student1 = new Student("Martin", "Lucas", "lucas.martin@student.com", "stud123") { SchoolClass = "Licence 1" };
            Student student2 = new Student("Bernard", "Sophie", "sophie.bernard@student.com", "stud123") { SchoolClass = "Licence 1" };
            Student student3 = new Student("Dubois", "Léo", "leo.dubois@student.com", "stud123") { SchoolClass = "Licence 2" };
            Student student4 = new Student("Rousseau", "Emma", "emma.rousseau@student.com", "stud123") { SchoolClass = "Licence 2" };
            Student student5 = new Student("Lefevre", "Hugo", "hugo.lefevre@student.com", "stud123") { SchoolClass = "Master 1" };

            Users.Add(student1);
            Users.Add(student2);
            Users.Add(student3);
            Users.Add(student4);
            Users.Add(student5);

            // --- COURS ---
            Courses courseMath1 = new Courses { Id = NextCourseId++, Title = "Algèbre Linéaire", Description = "Bases des espaces vectoriels et matrices.", ProfessorId = profMath.Id, IsPublished = true };
            Courses courseMath2 = new Courses { Id = NextCourseId++, Title = "Analyse Complexe", Description = "Fonctions holomorphes et intégrales de contour.", ProfessorId = profMath.Id, IsPublished = false };
            
            Courses coursePhys1 = new Courses { Id = NextCourseId++, Title = "Mécanique Quantique", Description = "Introduction aux concepts quantiques et équation de Schrödinger.", ProfessorId = profPhysique.Id, IsPublished = true };
            Courses coursePhys2 = new Courses { Id = NextCourseId++, Title = "Relativité Restreinte", Description = "Espace-temps de Minkowski.", ProfessorId = profPhysique.Id, IsPublished = true };

            Courses courseInfo1 = new Courses { Id = NextCourseId++, Title = "Programmation Orientée Objet", Description = "Maîtrise de l'héritage, du polymorphisme et du C#.", ProfessorId = profInfo.Id, IsPublished = true };
            Courses courseInfo2 = new Courses { Id = NextCourseId++, Title = "Architecture Réseau", Description = "Modèle OSI et protocoles TCP/IP.", ProfessorId = profInfo.Id, IsPublished = true };

            Courses.Add(courseMath1);
            Courses.Add(courseMath2);
            Courses.Add(coursePhys1);
            Courses.Add(coursePhys2);
            Courses.Add(courseInfo1);
            Courses.Add(courseInfo2);

            // --- NOTES ---
            // Notes de Lucas (Licence 1)
            Grades.Add(new Grade { Id = NextGradeId++, StudentId = student1.Id, CourseId = courseMath1.Id, Score = 14.5 });
            Grades.Add(new Grade { Id = NextGradeId++, StudentId = student1.Id, CourseId = coursePhys1.Id, Score = 12.0 });
            Grades.Add(new Grade { Id = NextGradeId++, StudentId = student1.Id, CourseId = courseInfo1.Id, Score = 18.0 });

            // Notes de Sophie (Licence 1)
            Grades.Add(new Grade { Id = NextGradeId++, StudentId = student2.Id, CourseId = courseMath1.Id, Score = 16.0 });
            Grades.Add(new Grade { Id = NextGradeId++, StudentId = student2.Id, CourseId = courseInfo1.Id, Score = 15.5 });

            // Notes de Léo (Licence 2)
            Grades.Add(new Grade { Id = NextGradeId++, StudentId = student3.Id, CourseId = coursePhys2.Id, Score = 11.5 });
            Grades.Add(new Grade { Id = NextGradeId++, StudentId = student3.Id, CourseId = courseInfo2.Id, Score = 19.0 });

            // Notes d'Emma (Licence 2)
            Grades.Add(new Grade { Id = NextGradeId++, StudentId = student4.Id, CourseId = coursePhys2.Id, Score = 17.5 });

            // Notes d'Hugo (Master 1)
            Grades.Add(new Grade { Id = NextGradeId++, StudentId = student5.Id, CourseId = courseInfo1.Id, Score = 20.0 });
        } 
    }
}
