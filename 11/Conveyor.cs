using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_1
{
    class Conveyor
    {
        public Conveyor() { }

        public void Sizes_Removed(Product prod)
        {
            prod.sizes_removed = true;
        }
        public void Cut_Off(Product prod)
        {
            prod.cut_off = true;
        }
        public void Sharpened(Product prod)
        {
            prod.sharpened = true;
        }
        public void The_Thread_Is_Cut(Product prod)
        {
            prod.the_thread_is_cut = true;
        }
        public void Drilled(Product prod)
        {
            prod.drilled = true;
        }
        public void Paintend(Product prod)
        {
            prod.painted = true;
        }
        public void Tested(Product prod)
        {
            prod.tested = true;
        }
        public void Packed(Product prod)
        {
            prod.packed = true;
        }
    }
}