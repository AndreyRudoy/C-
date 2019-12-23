using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
    class DiskPhone
    {
        protected string NameDevice;

        public DiskPhone(string nameOfDevice)
        {
            this.NameDevice = nameOfDevice;
        }
        public void GetName()
        {
            Console.WriteLine($"Name of device is: {NameDevice}");
        }
    }
}
