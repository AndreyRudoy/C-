// Lab 7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    class Program
    {
        static char[] Method(char[] a, char[] b) //5.1 метод приймає два масиви (перший - порожній, другий - той, що требе переписати задом наперед) і повертає перший з переписаними задом наперед елементами другого
        {
            int j = 0;
            for (int i = b.Length; i > 0; i--)
            {

                a[j] = b[i - 1];
                j++;
            }
            return a;
        }

        static char[] Method(char[] a) //5.2 (7 (приймає масив переписує його задом навпаки і виводить))
        {
            char[] arr_char_revers = new char[a.Length];
            int j = 0;
            for (int i = a.Length; i > 0; i--)
            {

                arr_char_revers[j] = a[i - 1];
                j++;
            }
            for (int i = 0; i < a.Length; i++)
            {

                a[i] = arr_char_revers[i];
                j++;
            }
            return a;
        }

        static void Method(ref string s) //5.3 (приймає рядок ділить масив на два крапкою (відображує кожен з масивів задом наперед зберігаючи місце крапки))
        {

            char[] arr_char = s.ToCharArray();
            char[] arr_char_revers = new char[arr_char.Length];
            int k = 0;

            for (int i = 0; i < arr_char.Length; i++) //підрахунок знаків разом з крапкою (не рахує далі крапки)
            {
                if (arr_char[i] == '.')
                {
                    k = i + 1;
                }

            }




            char[] a = new char[k];
            char[] b = new char[(arr_char.Length) - k];


            int j_1 = 0;                            ///nnnnn.
            for (int i = k - 2; i >= 0; i--)
            {
                a[j_1] = arr_char[i];
                j_1++;
            }
            a[k - 1] = '.';        //     .



            int j_2 = 0;                                           //.nnnn
            for (int i = arr_char.Length - 1; i > k - 1; i--)
            {
                b[j_2] = arr_char[i];
                j_2++;
            }



            for (int i = 0; i < k; i++)
            {
                arr_char_revers[i] = a[i];

            }



            int j_3 = 0;                                    //.nnn
            for (int i = k; i < arr_char.Length; i++)
            {
                arr_char_revers[i] = b[j_3];
                j_3++;

            }

            s = new string(arr_char_revers);

        }

        static string Method(out string s, int k, char[] arr_char) //5.4
        {

            char[] arr_char_revers = new char[arr_char.Length];



            char[] a = new char[k];
            char[] b = new char[(arr_char.Length) - k];


            int j_1 = 0;                            ///nnnnn,
            for (int i = k - 2; i >= 0; i--)
            {
                a[j_1] = arr_char[i];
                j_1++;
            }
            a[k - 1] = ',';        //     ,



            int j_2 = 0;                                           //,nnnn
            for (int i = arr_char.Length - 1; i > k - 1; i--)
            {
                b[j_2] = arr_char[i];
                j_2++;
            }



            for (int i = 0; i < k; i++)
            {
                arr_char_revers[i] = a[i];

            }



            int j_3 = 0;                                    //,nnn
            for (int i = k; i < arr_char.Length; i++)
            {
                arr_char_revers[i] = b[j_3];
                j_3++;

            }


            s = new string(arr_char_revers);
            return s;
        }


        static string Revers_arr(string a)       //не використовується (приймає стрінг і перетворює стрінг в масив чарів переписує задом навпаки і перетворює назад в стрінг і виводить як стрінг)
        {
            char[] arr_f = a.ToCharArray();
            char[] arr_char_revers = new char[a.Length];
            int j = 0;
            for (int i = a.Length; i > 0; i--)
            {

                arr_char_revers[j] = a[i - 1];
                j++;
            }
            string revers_string = new string(arr_char_revers);
            return revers_string;
        }

        static string Method_Recursion(char[] a, char[] arr_char_revers, int i, int j)       //6.1 (6.2)  (переписує )
        {


            arr_char_revers[j] = a[i - 1];
            if (arr_char_revers[a.Length - 1] == '\0')
            {
                return Method_Recursion(a, arr_char_revers, i - 1, j + 1);
            }
            else
            {
                string revers_string = new string(arr_char_revers);
                return revers_string;
            }
        }




        static char[] Method_Recursion(int k, int g, char[] arr_char_revers, char[] a, char[] b, int i, int j, int arr_char_length) //6.3  
        {



            if (i < k)
            {
                arr_char_revers[i] = a[i];
                return Method_Recursion(k, g, arr_char_revers, a, b, i + 1, j, arr_char_length);
            }
            else if (g < arr_char_length)
            {
                arr_char_revers[g] = b[j];
                return Method_Recursion(k, g + 1, arr_char_revers, a, b, i, j + 1, arr_char_length);
            }
            else
            {
                return arr_char_revers;
            }

        }



        static char[] Revers_arr(char[] a) //7 (приймає масив переписує його задом навпаки і виводить)
        {
            char[] arr_char_revers = new char[a.Length];
            int j = 0;
            for (int i = a.Length; i > 0; i--)
            {

                arr_char_revers[j] = a[i - 1];
                j++;
            }
            for (int i = 0; i < a.Length; i++)
            {

                a[i] = arr_char_revers[i];
                j++;
            }
            return a;
        }


        static void Revers_arr(ref char[] a) //8.1
        {
            char[] arr_char_revers = new char[a.Length];
            int j = 0;
            for (int i = a.Length; i > 0; i--)
            {

                arr_char_revers[j] = a[i - 1];
                j++;
            }
            for (int i = 0; i < a.Length; i++)
            {

                a[i] = arr_char_revers[i];
                j++;
            }
        }



        static void Revers_arr(out char[] a, string b) //8.2
        {
            a = b.ToCharArray();
            char[] arr_char_revers = new char[a.Length];
            int j = 0;
            for (int i = a.Length; i > 0; i--)
            {

                arr_char_revers[j] = a[i - 1];
                j++;
            }
            for (int i = 0; i < a.Length; i++)
            {

                a[i] = arr_char_revers[i];
                j++;
            }
        }



        static void Main(string[] args)
        {
            int v = 1;
            do
            {
                if (v < 1 || v > 8)
                {
                    Console.WriteLine("Select Task 1 or 2 or 3 or 4 or 5 or 6 or 7 or 8");
                }
                try
                {
                    Console.WriteLine("Select a task (1-8):");
                    v = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }

                switch (v)
                {
                    case 1:
                        {
                            //1
                            string enter_number;
                            char[] arr_char;


                            Console.WriteLine("Enter the number:");
                            enter_number = Console.ReadLine();
                            arr_char = enter_number.ToCharArray();

                            char[] arr_char_revers = new char[arr_char.Length];

                            int j = 0;
                            for (int i = arr_char.Length; i > 0; i--)
                            {

                                arr_char_revers[j] = arr_char[i - 1];
                                j++;
                            }
                            string revers_number = new string(arr_char_revers);
                            Console.WriteLine("{0}", revers_number);
                            break;
                        }
                    case 2:
                        {
                            //2
                            string enter_string;
                            char[] arr_char;


                            Console.WriteLine("Enter the string:");
                            enter_string = Console.ReadLine();            //tttttttt
                            arr_char = enter_string.ToCharArray();
                            char[] arr_char_revers = new char[arr_char.Length];

                            int j = 0;
                            for (int i = arr_char.Length; i > 0; i--)
                            {

                                arr_char_revers[j] = arr_char[i - 1];
                                j++;
                            }
                            string revers_string = new string(arr_char_revers);
                            Console.WriteLine("{0}", revers_string);
                            break;
                        }
                    case 3:
                        {
                            //3
                            string enter_string;
                            char[] arr_char;



                            Console.WriteLine("Enter the fractional number:");
                            enter_string = Console.ReadLine();            //tttttttt
                            arr_char = enter_string.ToCharArray();

                            char[] arr_char_revers = new char[arr_char.Length];




                            int k = 0;

                            for (int i = 0; i < arr_char.Length; i++) //підрахунок знаків разом з крапкою
                            {
                                if (arr_char[i] == '.')
                                {
                                    k = i + 1;
                                }

                            }




                            char[] a = new char[k];
                            char[] b = new char[(arr_char.Length) - k];


                            int j_1 = 0;                            ///nnnnn.
                            for (int i = k - 2; i >= 0; i--)
                            {
                                a[j_1] = arr_char[i];
                                j_1++;
                            }
                            a[k - 1] = '.';        //     .



                            int j_2 = 0;                                           //.nnnn
                            for (int i = arr_char.Length - 1; i > k - 1; i--)
                            {
                                b[j_2] = arr_char[i];
                                j_2++;
                            }



                            for (int i = 0; i < k; i++)
                            {
                                arr_char_revers[i] = a[i];

                            }



                            int j_3 = 0;                                    //.nnn
                            for (int i = k; i < arr_char.Length; i++)
                            {
                                arr_char_revers[i] = b[j_3];
                                j_3++;

                            }


                            string revers_string = new string(arr_char_revers);
                            Console.WriteLine("{0}", revers_string);
                            break;
                        }
                    case 4:
                        {
                            //4
                            string enter_string;
                            char[] arr_char;



                            Console.WriteLine("Enter the string:");
                            enter_string = Console.ReadLine();            //tttttttt
                            arr_char = enter_string.ToCharArray();

                            char[] arr_char_revers = new char[arr_char.Length];




                            int k = 0;

                            for (int i = 0; i < arr_char.Length; i++) //підрахунок знаків разом з маг.знак
                            {
                                if (arr_char[i] == ',')
                                {
                                    k = i + 1;
                                }

                            }




                            char[] a = new char[k];
                            char[] b = new char[(arr_char.Length) - k];


                            int j_1 = 0;                            ///nnnnn,
                            for (int i = k - 2; i >= 0; i--)
                            {
                                a[j_1] = arr_char[i];
                                j_1++;
                            }
                            a[k - 1] = ',';        //     ,



                            int j_2 = 0;                                           //,nnnn
                            for (int i = arr_char.Length - 1; i > k - 1; i--)
                            {
                                b[j_2] = arr_char[i];
                                j_2++;
                            }



                            for (int i = 0; i < k; i++)
                            {
                                arr_char_revers[i] = a[i];

                            }



                            int j_3 = 0;                                    //,nnn
                            for (int i = k; i < arr_char.Length; i++)
                            {
                                arr_char_revers[i] = b[j_3];
                                j_3++;

                            }


                            string revers_string = new string(arr_char_revers);
                            Console.WriteLine("{0}", revers_string);
                            break;
                        }
                    case 5:
                        {
                            //5


                            int v_1 = 0;
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Select a task (1-4)");
                                    v_1 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    break;
                                }

                                if (v_1 < 1 || v_1 > 8)
                                {
                                    Console.WriteLine("Select Task 1 or 2 or 3 or 4");
                                }

                                switch (v_1)
                                {
                                    case 1:
                                        {
                                            //1
                                            string enter_number;
                                            char[] arr_char;


                                            Console.WriteLine("Enter the number:");
                                            enter_number = Console.ReadLine();
                                            arr_char = enter_number.ToCharArray();
                                            char[] arr_char_revers = new char[arr_char.Length];


                                            string revers_number = new string(Method(arr_char_revers, arr_char));
                                            Console.WriteLine("{0}", revers_number);
                                            break;
                                        }
                                    case 2:
                                        {
                                            //2
                                            string enter_string;
                                            char[] arr_char;


                                            Console.WriteLine("Enter the string:");
                                            enter_string = Console.ReadLine();            //tttttttt
                                            arr_char = enter_string.ToCharArray();



                                            string revers_string = new string(Method(arr_char));
                                            Console.WriteLine("{0}", revers_string);
                                            break;
                                        }
                                    case 3:
                                        {
                                            //3
                                            string enter_string;
                                            Console.WriteLine("Enter the fractional number:");
                                            enter_string = Console.ReadLine();            //tttttttt
                                            Method(ref enter_string);
                                            Console.WriteLine(enter_string);
                                            break;
                                        }
                                    case 4:
                                        {

                                            //4
                                            string enter_string;




                                            Console.WriteLine("Enter the string:");
                                            enter_string = Console.ReadLine();            //tttttttt
                                            char[] arr_char = enter_string.ToCharArray();






                                            int k = 0;

                                            for (int i = 0; i < arr_char.Length; i++) //підрахунок знаків разом з маг.знак
                                            {
                                                if (arr_char[i] == ',')
                                                {
                                                    k = i + 1;
                                                }

                                            }


                                            Console.WriteLine(Method(out enter_string, k, arr_char));
                                            break;
                                        }
                                    default:
                                        {
                                            break;
                                        }
                                }

                            } while (v_1 < 1 || v_1 > 4);


                            break;
                        }
                    case 6:
                        {
                            //6

                            int v_2 = 0;
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Select a task (1-4)");
                                    v_2 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    break;
                                }

                                if (v_2 < 1 || v_2 > 8)
                                {
                                    Console.WriteLine("Select Task 1 or 2 or 3 or 4");
                                }

                                switch (v_2)
                                {
                                    case 1:
                                        {
                                            //1
                                            string enter_number;
                                            char[] arr_char;


                                            Console.WriteLine("Enter the number:");
                                            enter_number = Console.ReadLine();
                                            arr_char = enter_number.ToCharArray();
                                            char[] arr_char_revers = new char[arr_char.Length];

                                            int i = enter_number.Length;
                                            int j = 0;
                                            Console.WriteLine(Method_Recursion(arr_char, arr_char_revers, i, j));
                                            break;
                                        }
                                    case 2:
                                        {
                                            //2
                                            string enter_string;
                                            char[] arr_char;


                                            Console.WriteLine("Enter the string:");
                                            enter_string = Console.ReadLine();
                                            arr_char = enter_string.ToCharArray();
                                            char[] arr_char_revers = new char[arr_char.Length];

                                            int i = enter_string.Length;
                                            int j = 0;
                                            Console.WriteLine(Method_Recursion(arr_char, arr_char_revers, i, j));
                                            break;
                                        }
                                    case 3:
                                        {
                                            //3
                                            string enter_string;
                                            char[] arr_char;



                                            Console.WriteLine("Enter the fractional number:");
                                            enter_string = Console.ReadLine();            //tttttttt
                                            arr_char = enter_string.ToCharArray();






                                            int k = 0;

                                            for (int i = 0; i < arr_char.Length; i++) //підрахунок знаків разом з крапкою
                                            {
                                                if (arr_char[i] == '.')
                                                {
                                                    k = i + 1;
                                                }

                                            }




                                            char[] a = new char[k];
                                            char[] b = new char[(arr_char.Length) - k];


                                            int j_1 = 0;                            ///nnnnn.
                                            for (int i = k - 2; i >= 0; i--)
                                            {
                                                a[j_1] = arr_char[i];
                                                j_1++;
                                            }
                                            a[k - 1] = '.';        //     .



                                            int j_2 = 0;                                           //.nnnn
                                            for (int i = arr_char.Length - 1; i > k - 1; i--)
                                            {
                                                b[j_2] = arr_char[i];
                                                j_2++;
                                            }


                                            char[] arr_char_revers = new char[arr_char.Length];

                                            int g = k;//k знаки разом з крапкою

                                            int j_3 = 0; //для підрахунку



                                            string revers_string = new string(Method_Recursion(k, g, arr_char_revers, a, b, j_3, j_3, arr_char.Length));
                                            Console.WriteLine(revers_string);
                                            break;
                                        }
                                    case 4:
                                        {

                                            //4
                                            string enter_string;
                                            char[] arr_char;



                                            Console.WriteLine("Enter the string:");
                                            enter_string = Console.ReadLine();            //tttttttt
                                            arr_char = enter_string.ToCharArray();






                                            int k = 0;

                                            for (int i = 0; i < arr_char.Length; i++) //підрахунок знаків разом з крапкою
                                            {
                                                if (arr_char[i] == ',')
                                                {
                                                    k = i + 1;
                                                }

                                            }




                                            char[] a = new char[k];
                                            char[] b = new char[(arr_char.Length) - k];


                                            int j_1 = 0;                            ///nnnnn.
                                            for (int i = k - 2; i >= 0; i--)
                                            {
                                                a[j_1] = arr_char[i];
                                                j_1++;
                                            }
                                            a[k - 1] = ',';        //     .



                                            int j_2 = 0;                                           //.nnnn
                                            for (int i = arr_char.Length - 1; i > k - 1; i--)
                                            {
                                                b[j_2] = arr_char[i];
                                                j_2++;
                                            }


                                            char[] arr_char_revers = new char[arr_char.Length];

                                            int g = k;//k знаки разом з крапкою

                                            int j_3 = 0; //для підрахунку


                                            Console.WriteLine(Method_Recursion(k, g, arr_char_revers, a, b, j_3, j_3, arr_char.Length));
                                            break;
                                        }
                                    default:
                                        {
                                            break;
                                        }
                                }

                            } while (v_2 < 1 || v_2 > 4);
                            break;
                        }
                    case 7:
                        {
                            string arr_str;
                            char[] arr_c;
                            Console.WriteLine("Enter array:");
                            arr_str = Console.ReadLine();
                            arr_c = arr_str.ToCharArray();
                            arr_str = new string(Revers_arr(arr_c));
                            Console.WriteLine(arr_str);
                            break;
                        }
                    case 8:
                        {


                            int v_3 = 0;
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Choose from ref(enter 1) or out(enter 2)");
                                    v_3 = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    break;
                                }
                                if (v_3 < 1 || v_3 > 8)
                                {
                                    Console.WriteLine("Option ref(enter 1) or out(enter 2)");
                                }

                                switch (v_3)
                                {
                                    case 1:
                                        {
                                            string arr_str;
                                            Console.WriteLine("Enter array:");
                                            arr_str = Console.ReadLine();

                                            char[] arr_c = arr_str.ToCharArray();
                                            Revers_arr(ref arr_c);
                                            arr_str = new string(arr_c);
                                            Console.WriteLine(arr_str);
                                            break;
                                        }
                                    case 2:
                                        {
                                            string arr_str;
                                            Console.WriteLine("Enter array:");
                                            arr_str = Console.ReadLine();

                                            char[] arr_c;
                                            Revers_arr(out arr_c, arr_str);
                                            arr_str = new string(arr_c);
                                            Console.WriteLine(arr_str);
                                            break;
                                        }
                                    default:
                                        {
                                            break;
                                        }
                                }

                            } while (v_3 < 1 || v_3 > 2);


                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (v < 1 || v > 8);



            Console.ReadKey();
        }
    }
}
