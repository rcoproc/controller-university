﻿using ControllerUniversity.Models;
using System;
using System.Linq;

namespace ControllerUniversity.Dados
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstMidName="Ricardo",LastName="Oliveira",EnrollmentDate=DateTime.Parse("2015-09-01")},
            new Student{FirstMidName="Mario",LastName="Nantes",EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Student{FirstMidName="Maria",LastName="Aparecida",EnrollmentDate=DateTime.Parse("2013-09-01")},
            new Student{FirstMidName="Halysson",LastName="Matos",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2011-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2013-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2015-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Química",Credits=3},
            new Course{CourseID=4022,Title="Microeconomia",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomia",Credits=3},
            new Course{CourseID=1045,Title="Cálculo",Credits=4},
            new Course{CourseID=3141,Title="Trigonometria",Credits=4},
            new Course{CourseID=2021,Title="Análise de Sistemas",Credits=3},
            new Course{CourseID=2042,Title="Literatura",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}