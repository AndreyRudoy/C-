using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main()
        {
            string s = null;
            int nk = 0;
            int nn = 0;
            bool next = false;

            do
            {
                if (next != true)
                {
                    Console.Write("NN: ");
                    s = Console.ReadLine();
                    if (int.TryParse(s, out nn))
                    {
                        if (nn >= 0)
                        {
                            next = true;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                }

                if (next == true)
                {
                    Console.Write("NK: ");
                    s = Console.ReadLine();
                    if (int.TryParse(s, out nk))
                    {
                        if (nk >= nn)
                        {
                            s = null;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                }
            } while (s != null);

            double sum = 0;
            for (int k = nn; k < nk; k++)
            {
                sum += (Math.Pow(k, 2) + Math.Pow(-1, k) * k - 1) / (Math.Pow(k, 2) + 1);
            }

            Console.WriteLine("E: {0}", sum);

            Console.ReadKey();
        }
    }
}
