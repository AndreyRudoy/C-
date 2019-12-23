using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main()
        {
            string s = null;
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;
            bool hx = false; 

            do
            {
                if (hx != true)
                {
                    Console.Write("X1: ");
                    s = Console.ReadLine();
                    if(int.TryParse(s, out x1))
                    {
                        if (x1 >= 1 && x1 <= 8)
                            hx = true;
                        else
                            Console.WriteLine("Ошибка");
                    }
                    else
                        Console.WriteLine("Ошибка");
                }
                else
                {
                    Console.Write("Y1: ");
                    s = Console.ReadLine();
                    if (int.TryParse(s, out y1))
                    {
                        if (y1 >= 1 && y1 <= 8)
                        {
                            s = null;
                            hx = false;
                        }
                        else
                            Console.WriteLine("Ошибка");
                    }
                    else
                        Console.WriteLine("Ошибка");
                }
            } while (s != null);

            do
            {
                if (hx != true)
                {
                    Console.Write("X2: ");
                    s = Console.ReadLine();
                    if (int.TryParse(s, out x2))
                    {
                        if (x2 >= 1 && x2 <= 8)
                            hx = true;
                        else
                            Console.WriteLine("Ошибка");
                    }
                    else
                        Console.WriteLine("Ошибка");
                }
                else
                {
                    Console.Write("Y2: ");
                    s = Console.ReadLine();
                    if (int.TryParse(s, out y2))
                    {
                        if (y2 >= 1 && y2 <= 8)
                            s = null;
                        else
                            Console.WriteLine("Ошибка");
                    }
                    else
                        Console.WriteLine("Ошибка");
                }
            } while (s != null);

            if(x1 == x2)
            {
                if((y1 > 4 && y2 <= 4) || (y1 <= 4 && y2 > 4))
                {
                    Console.WriteLine("Может!");
                }
                else
                    Console.WriteLine("Не может!");
            }
            else
                Console.WriteLine("Не может!");

            Console.ReadKey();
        }
    }
}
