﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Instructor
    {
        public string FirstName;
        public string LastName;
        public string CourseName;
        public int Grade;
        public string StudentName;

        public Instructor(string theirFirstName, string theirLastName, string theirCourseName)
        {
            this.FirstName = theirFirstName;
            this.LastName = theirLastName;
            this.CourseName = theirCourseName;





            System.Console.WriteLine(this.FirstName + " " + this.LastName + " "+ this.CourseName);

        }
        public void SetStudentGrade(Student student, int grade)
        {
            student.Grade = grade;
        }




    }
}
