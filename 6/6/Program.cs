using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main()
        {
            string s = null;
            List<double> ld = new List<double>();
            double pere = 0;

            Console.WriteLine("Добавляйте элемент. Дробную часть писать через ,. Чтобы закончить напишите .");
            do
            {
                s = Console.ReadLine();
                if(double.TryParse(s, out pere))
                {
                    ld.Add(pere);
                }
                else
                {
                    if (s.Trim() == ".")
                        s = null;
                    else
                        Console.WriteLine("Ошибка");
                }
            } while (s != null);

            Console.WriteLine("Проверочной элемент:");
            do
            {
                s = Console.ReadLine();
                if (double.TryParse(s, out pere))
                    s = null;
                else
                    Console.WriteLine("Ошибка");
            } while (s != null);

            double[] arrD = new double[ld.Count];
            Console.WriteLine("Индексы элементов равные проверочному элементу:");
            for (int i = 0; i < ld.Count(); i++)
            {
                arrD[i] = ld[i];
                if(ld[i] == pere)
                {
                    Console.WriteLine("{0}\t", i);
                }
            }

            Console.WriteLine("Масив:");
            for (int i = 0; i < ld.Count(); i++)
            {
                 Console.Write("{0} ", arrD[i]);
            }

            Console.ReadKey();
        }
    }
}
