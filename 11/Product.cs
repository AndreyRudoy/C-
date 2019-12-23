using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_1
{
    class Product
    {
        public bool sizes_removed { get; set; }
        public bool cut_off { get; set; }
        public bool sharpened { get; set; }
        public bool the_thread_is_cut { get; set; }
        public bool drilled { get; set; }
        public bool painted { get; set; }
        public bool tested { get; set; }
        public bool packed { get; set; }
        public Product()
        {
            sizes_removed = false;
            cut_off = false;
            sharpened = false;
            the_thread_is_cut = false;
            drilled = false;
            painted = false;
            tested = false;
            packed = false;
        }
        public void OutputInfo()
        {
            Console.WriteLine(" Status of product:");
            Console.WriteLine($"Sizes_Removed = {sizes_removed}");
            Console.WriteLine($"Cut_Off = {cut_off}");
            Console.WriteLine($"Sharpened = {sharpened}");
            Console.WriteLine($"The_Thread_Is_Cut = {the_thread_is_cut}");
            Console.WriteLine($"Drilled ={drilled}");
            Console.WriteLine($"Painted = {painted}");
            Console.WriteLine($"Tested = {tested}");
            Console.WriteLine($"Packed = {packed}");
        }

    }
}
