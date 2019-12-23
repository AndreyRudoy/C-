using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_2
{
    static class Extension
    {

        public static List<Student> FindStudent(this List<Student> listStud)
        {
            StudentPredicateDelegate Stud_Deleg_1 = Student.Age_Value;
            StudentPredicateDelegate Stud_Deleg_2 = Student.FirstName_Value;
            StudentPredicateDelegate Stud_Deleg_3 = Student.LastName_Value;


            List<Student> Sort_List_Stud = new List<Student>();
            for (int i = 0; i < listStud.Count; i++)
            {
                if (Stud_Deleg_1(listStud[i]) && Stud_Deleg_2(listStud[i]) && Stud_Deleg_3(listStud[i]))
                {
                    Sort_List_Stud.Add(listStud[i]);
                }
            }

            return Sort_List_Stud;
        }

        public static void GetInfo(this List<Student> sort_list_stud)
        {
            int i = 0;
            foreach (Student uc in sort_list_stud)
            {
                Console.WriteLine("Number: " + (++i));
                Console.WriteLine(uc);
                Console.WriteLine();
            }
        }

        public static void Search(this List<Student> sort_list_stud)
        {
            Console.WriteLine("Age 20<---->25");
            foreach (Student s1 in sort_list_stud)
            {
                
                if (s1.Age >= 20 && s1.Age <= 25)
                {
                    Console.WriteLine(s1);
                    Console.WriteLine();
                }


            }

            foreach (Student s2 in sort_list_stud)
            {
                if (s2.FirstName == "Andrew")
                {
                    Console.WriteLine("First Name Andrew");
                    Console.WriteLine(s2);
                    Console.WriteLine();
                }
                
            }

            foreach (Student s3 in sort_list_stud)
            {
                if (s3.LastName == "Troelsen")
                {
                    Console.WriteLine("Last Name Troelsen");
                    Console.WriteLine(s3);
                    Console.WriteLine();
                }
            }


        }
    }
}
