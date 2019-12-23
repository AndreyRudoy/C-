using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    class Car
    {
        protected string name_car;
        protected string color_car;
        protected int speed_car;
        protected int graduation_year_car;

        public string Name_car
        {
            get
            {
                return name_car;
            }
        }

        public string Color_car
        {
            get
            {
                return color_car;
            }
        }

        public int Speed_car
        {
            get
            {
                return speed_car;
            }
        }

        public int Graduation_year_car
        {
            get
            {
                return graduation_year_car;
            }
        }

        public Car(string name_car, string color_car, int speed_car, int graduation_year_car)
        {
            this.name_car = name_car;
            this.color_car = color_car;
            this.speed_car = speed_car;
            this.graduation_year_car = graduation_year_car;
        }
    }
}
