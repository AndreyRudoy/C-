using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    class Sheikh_Garage
    {
        List<Car> cars = new List<Car>();

        protected Car Enter_Data()
        {
            string name;
            string color;
            int speed = 0;
            int year = 0;

            do
            {
                Console.Write("Enter name of car: ");
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("You did not enter a name. Try again");
                }
            } while (name == "");

            do
            {
                Console.Write("Enter color of car: ");
                color = Console.ReadLine();
                if (color == "")
                {
                    Console.WriteLine("You did not enter a color. Try again");
                }
            } while (color == "");

            do
            {
                Console.Write("Enter speed of car: ");
                try
                {
                    speed = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                if (speed <= 0)
                {
                    Console.WriteLine("Speed cannot be negative or = 0. Try again");
                }
            } while (speed <= 0);

            do
            {
                Console.Write("Enter year of creation of car: ");
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (year < 1768 || year > DateTime.Today.Year)
                {
                    Console.WriteLine("The interval is possible from 1768 to the present day. Try again");  // https://ru.wikipedia.org/wiki/%D0%98%D1%81%D1%82%D0%BE%D1%80%D0%B8%D1%8F_%D0%B0%D0%B2%D1%82%D0%BE%D0%BC%D0%BE%D0%B1%D0%B8%D0%BB%D1%8F
                }
            } while (year < 1768 || year > DateTime.Today.Year);

            return new Car(name, color, speed, year);
        }


        public void AddCar()
        {
            cars.Add(Enter_Data());
        }

        public void ViewCars()
        {
            Console.WriteLine("All your cars:");
            Console.WriteLine(" Number  Name    Color   Speed   Year of creation\n");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"    {i + 1}         {cars[i].Name_car}         {cars[i].Color_car}        {cars[i].Speed_car}          {cars[i].Graduation_year_car}");
            }
        }

        public void DeleteCar()
        {
            ViewCars();
            int a;
            do
            {
                Console.Write("Enter number of car what You want delete:");
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 1 || a > cars.Count + 1)
                {
                    Console.WriteLine("Incorrect number of car! Try again");
                }
                else
                {
                    Console.WriteLine("Remove successful");
                }
            } while (a < 1 || a > cars.Count + 1);
            cars.RemoveAt(a - 1);
        }


        public void GetCar()
        {

            int a;
            do
            {
                Console.Write("What nubber of car do you want to take? ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a - 1 < 0 || a - 1 > cars.Count)
                {
                    Console.WriteLine("Incorrect number of Car. Try again");
                }
                else
                {
                    Console.WriteLine("Successful trip");
                }
            } while (a - 1 < 0 || a - 1 > cars.Count);
        }
    }
}
