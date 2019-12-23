using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main()
        {
            string s = null;
            double r = 0;
            int n = 0;
            do
            {
                Console.Write("N: ");
                s = Console.ReadLine();
                if (int.TryParse(s, out n))
                {
                    s = null;
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            } while (s != null);

            double[] arr = new double[n];
            for(int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write("Arr[{0}]: " ,i);
                    s = Console.ReadLine();
                    if (double.TryParse(s, out arr[i]))
                    {
                        s = null;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                } while (s != null);
            }

            do
            {
                Console.Write("R: ");
                s = Console.ReadLine();
                if (double.TryParse(s, out r))
                {
                    s = null;
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            } while (s != null);


            double min = r;
            double max = 0;
            int minin = 0;
            int maxin = 0;
            for (int i = 0; i < n; i++)
            {
                if(r - arr[i] > max)
                {
                    max = r - arr[i];
                    maxin = i;
                }

                if (r - arr[i] < min)
                {
                    min = r - arr[i];
                    minin = i;
                }
            }

            Console.WriteLine("Cамый близкий: {0}, индекс {1}", arr[minin], minin);
            Console.WriteLine("Cамый дальний: {0}, индекс {1}", arr[maxin], maxin);
            Console.ReadKey();
        }
    }
}
