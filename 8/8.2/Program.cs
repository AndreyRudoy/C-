using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            GoogleGlass google_glasse = new GoogleGlass("");
            MobileWithColorScreen phone = new MobileWithColorScreen("");
            google_glasse.GetName();
            phone.GetName();
            Console.ReadLine();
        }
    }
}
