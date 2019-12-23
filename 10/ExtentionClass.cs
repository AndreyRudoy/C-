using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    static class ExtentionClass
    {
        public static void Sorting_Growth_Show_Array(this List list)
        {
            int var;
            for (int i = 0; i < list.size - 1; i++)
            {
                for (int j = 0; j < list.size - 1; j++)
                {
                    if (list.arr[j] > list.arr[j + 1])
                    {
                        var = list.arr[j];
                        list.arr[j] = list.arr[j + 1];
                        list.arr[j + 1] = var;
                    }
                }
            }

            list.DisplayList();

        }
    }
    
}
