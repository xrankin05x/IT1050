using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Kim_R
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string MaritalStatus;
        public string Spouse;
        public int AgeSpouse;
        public string GetFullName()
        {
            return this.FirstName + "" +this.LastName;
          
        }

        public int GetSumOfAllAges()
        {
            return this.Age ;
        }



        




    }
}
