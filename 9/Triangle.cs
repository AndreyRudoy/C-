using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9__1._1_
{
    class Triangle : Shape //(рівнобедрений трикутник – задається довжина сторони)
    {
        private string color_figure;

        public override string Color_Figure
        {
            get { return color_figure; }
            set { color_figure = value; }
        }

        private int number_vertex;

        public override int Number_Vertex
        {
            get { return number_vertex; }

        }

        private string name_object;

        public override string Name_Object
        {
            get { return name_object; }

        }





        public override int Сalculating_Area(/**/)
        {


        }
        public override int Сalculating_Perimeter(/**/)
        {


        }



        public Triangle(int a) //конструктор з одним параметром (приймає ім’я та задає випадкові розмір фігури і колір)
        {

        }
        public Triangle(int a, int b) //конструктор з двома параметрами (приймає ім’я та розмір фігури, колір випадковий)
        {

        }
        public Triangle(int a, int b, int c) //конструктор з трьома параметрами (приймає ім’я та розмір фігури та колір фігури)
        {

        }
    }
}
