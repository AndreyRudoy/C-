using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main()
        {
            string s = null;
            int m = 0;
            do
            {
                Console.Write("M: ");
                s = Console.ReadLine();
                if (int.TryParse(s, out m))
                    s = null;
                else
                    Console.WriteLine("Ошибка");
            } while (s != null);

            int[,] arr = new int[m, m];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    do
                    {
                        Console.Write("Arr[{0},{1}]: ", i, j);
                        s = Console.ReadLine();
                        if (int.TryParse(s, out arr[i, j]))
                            s = null;
                        else
                            Console.WriteLine("Ошибка");
                    } while (s != null);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("{0}\t", arr[i, j]);
                Console.WriteLine();
            }

            int swn = 0;
            Console.WriteLine("Отразить по:");
            Console.WriteLine("1) горизонтальной оси симметрии");
            Console.WriteLine("2) вертикальной оси симметрии");
            Console.WriteLine("3) главной диагонали");
            Console.WriteLine("4) побочного диагонали матрицы");
            do
            {
                Console.Write("Выберите: ");
                s = Console.ReadLine();
                if (int.TryParse(s, out swn))
                {
                    if (swn >= 1 && swn <= 4)
                        s = null;
                }
                else
                    Console.WriteLine("Ошибка");
            } while (s != null);

            switch (swn)
            {
                case (1):
                    {
                        int[] arrev = new int[m];
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                arrev[j] = arr[i, j];
                            }

                            Array.Reverse(arrev);

                            for (int j = 0; j < m; j++)
                            {
                                arr[i, j] = arrev[j];
                            }
                        }
                        break;
                    }
                case (2):
                    {
                        int[] arrev = new int[m];
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                arrev[j] = arr[j, i];
                            }

                            Array.Reverse(arrev);

                            for (int j = 0; j < m; j++)
                            {
                                arr[j, i] = arrev[j];
                            }
                        }
                        break;
                    }

                case (3):
                    {
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                int t = arr[i, j];
                                arr[i, j] = arr[j, i];
                                arr[j, i] = t;
                            }
                        }
                        break;
                    }
                case (4):
                    {
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < m - i; j++)
                            {
                                int t = arr[i, j];
                                arr[i, j] = arr[m - j - 1, m - i - 1];
                                arr[m - j - 1, m - i - 1] = t;
                            }
                        }
                        break;
                    }

            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("{0}\t", arr[i, j]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}