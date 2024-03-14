﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Mateo_Makovac_3._2
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };

            Student[] students = new Student[10];

            int i = 0;

            var studenti = from s in studentArray
                           where s.Age > 12 && s.Age < 20
                           orderby s.Age descending
                           select s;

            foreach (var stu in studenti)
            {
                Console.WriteLine("Ime: {0} Godine: {1} ", stu.StudentName, stu.Age);
            }

            Console.ReadKey();
        }
    }
}