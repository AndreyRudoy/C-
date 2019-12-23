using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    public class List
    {

        public int sum_prost = 0;
        public int rizn_parn = 0;
        public int sum_parn = 0;
        public int arithmetic_mean;
        public int all_sum = 0;
        public List<int> elements = new List<int>();
        protected string str;
        public int size = 0;
        public int[] arr_sort;
        protected string[] str_arr;
        public int[] arr;


        public void Task_Notification()
        {
            Console.WriteLine("Enter list (Numeric values can be separated by a space.)");
            Console.WriteLine("For example: 123 1113 208 75");
        }

        public void Transformation()
        {
            str = Console.ReadLine();
            str_arr = str.Split(' ');
            arr = new int[str.Length];
        }

        public void Verification_Int()
        {
            for (int i = 0; i < str_arr.Length; i++)
            {

                try
                {
                    arr[i] = Convert.ToInt32(str_arr[i]);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    return;
                }
            }
        }

        public void AddElement(int[] arr, int i)
        {
            elements.Add(arr[i]);
            size++;
        }

        public void Calculations()
        {
            for (int i = 0; i < str_arr.Length; i++)
            {
                AddElement(arr, i);


                if (((arr[i] % 2) != 0 && (arr[i] % 3) != 0 && arr[i] != 1) || arr[i] == 2 || arr[i] == 3)
                {
                    sum_prost += arr[i];
                }

                if ((arr[i] % 2) == 0)
                {
                    sum_parn += arr[i];
                }

                all_sum += arr[i];

            }
            arithmetic_mean = all_sum / str_arr.Length;
            rizn_parn = sum_prost - sum_parn;
        }

        public int Size()
        {
            return size;
        }

        public void Values_Found()
        {
            Console.WriteLine("Sum simple elements = {0}", sum_prost);

            Console.WriteLine("Sum paired elements = {0}", sum_parn);

            Console.WriteLine("Sum simple elements - Sum paired elements = {0}", rizn_parn);

            Console.WriteLine("Arithmetic mean = {0}", arithmetic_mean);
        }


        

        public void DisplayList()
        {
            Console.Write($"Sorted array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]} ");
            }
        }

    }



    class List_int
    {
        static void Main(string[] args)
        {
            List int_list = new List();
            int_list.Task_Notification();
            int_list.Transformation();
            int_list.Verification_Int();
            int_list.Calculations();
            int_list.Values_Found();
         
            int_list.Sorting_Growth_Show_Array();
            Console.ReadKey();
        }
    }
}
