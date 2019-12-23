using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Sheikh_Garage garage = new Sheikh_Garage();

            Console.WriteLine("Initially, there were 3 cars in the garage. What kind of cars are these?");

            for (int i = 0; i < 3; i++)
            {
                garage.AddCar();
            }
            int n;
            do
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Add a car - 1");
                Console.WriteLine("Throw away the car - 2");
                Console.WriteLine("Take a ride on the criteria - 3");
                Console.WriteLine("Go out - 4");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        {
                            garage.AddCar();
                            break;
                        }
                    case 2:
                        {
                            garage.DeleteCar();
                            break;
                        }
                    case 3:
                        {
                            garage.GetCar();
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                }
            } while (n != 4);


            garage.ViewCars();










            Console.ReadKey();
        }
    }
}
