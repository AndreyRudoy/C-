using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_1
{
    class Program
    {
        public delegate void DelegateConveyor(Product prod);

        static void Main(string[] args)
        {
            Product prod = new Product();

            prod.OutputInfo();

            Conveyor example_conveyor = new Conveyor();
            DelegateConveyor conveyor = example_conveyor.Sizes_Removed;
            conveyor += example_conveyor.Cut_Off;
            conveyor += example_conveyor.Sharpened;
            conveyor += example_conveyor.The_Thread_Is_Cut;
            conveyor += example_conveyor.Drilled;
            conveyor += example_conveyor.Paintend;
            conveyor += example_conveyor.Tested;
            conveyor += example_conveyor.Packed;
            conveyor(prod);

            prod.OutputInfo();


            Console.ReadKey();
        }
    }
}
