using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9__1._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose figure:");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Triangle");
            int n = Convert.ToInt32(Console.ReadLine());


            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("You have selected a square!");
                        Console.WriteLine("Now set the color.");
                        Shape square = new Square(Console.ReadLine());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("You have selected a circle!");
                        Console.WriteLine("Now set the color.");
                        Shape circle = new Circle(Console.ReadLine());
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("You have selected a triangle!");
                        Console.WriteLine("Now set the color.");
                        Shape triangle = new Triangle(Console.ReadLine());
                        break;
                    }
                default:
                    {
                        break;
                    }
            }










            Console.ReadKey();
        }
    }
}
