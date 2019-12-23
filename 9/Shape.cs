using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9__1._1_
{
    abstract class Shape
    {
        public abstract string Color_Figure { get; set; } //властивість (читання і запис)
        public abstract int Number_Vertex { get; } //властивість (тільки читання)
        public abstract string Name_Object { get; } //властивість (тільки читання)

        public abstract int Сalculating_Area(); //метод обрахунок площі
        public abstract int Сalculating_Perimeter(); //метод обрахунок периметру
    }
}
