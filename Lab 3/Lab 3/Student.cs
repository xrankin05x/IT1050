using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Student
    {
        public string StudentName;
        public string Teacher;
        public int Grade;

        public Student(string theirStudentName, int theirGrade, string theirTeacher)
        {
            this.StudentName = theirStudentName;
            this.Grade = theirGrade;
            this.Teacher = theirTeacher;


            
            
            System.Console.WriteLine(this.StudentName + this.Grade + this.Teacher);


        }

        public void SetGrade(Student student, int grade)
        {
            student.Grade = grade;
        }
         
        
            
          
             
    }
 }
   
