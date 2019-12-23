using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_2
{
    class Student
    {

        public string FirstName { get; set; } //властивість
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Name: " + FirstName + "\nLast name: " + LastName + "\nAge: " + Age;
        }

        public static bool Age_Value(Student str)
        {
            return (str.Age >= 18 ? true : false);
        }

        public static bool FirstName_Value(Student str)
        {
            return (str.FirstName.IndexOf("A") == 0 ? true : false);
        }

        public static bool LastName_Value(Student str)
        {
            return (str.LastName.Length > 3 ? true : false);
        }
    }
}
