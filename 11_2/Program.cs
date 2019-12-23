using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_2
{
    delegate bool StudentPredicateDelegate(Student str);

    class Program
    {

        static void Main(string[] args)
        {
            List<Student> listStud = new List<Student>();

            listStud.Add(new Student() { Age = 15, FirstName = "Ada", LastName = "Smith" });
            listStud.Add(new Student() { Age = 18, FirstName = "Piers", LastName = "Johnson" });
            listStud.Add(new Student() { Age = 17, FirstName = "Fergus", LastName = "Williams" });
            listStud.Add(new Student() { Age = 23, FirstName = "Alex", LastName = "Jones" });
            listStud.Add(new Student() { Age = 24, FirstName = "Nora", LastName = "Li" });
            listStud.Add(new Student() { Age = 20, FirstName = "Andrew", LastName = "Anderson" });
            listStud.Add(new Student() { Age = 31, FirstName = "Brian", LastName = "White" });
            listStud.Add(new Student() { Age = 29, FirstName = "Carl", LastName = "Martin" });
            listStud.Add(new Student() { Age = 19, FirstName = "Gladys", LastName = "Troelsen" });
            listStud.Add(new Student() { Age = 18, FirstName = "Agatha", LastName = "King" });

            List<Student> sort_list_stud = listStud.FindStudent();
            sort_list_stud.GetInfo();
            listStud.Search();

            Console.ReadLine();
        }
    }
}
