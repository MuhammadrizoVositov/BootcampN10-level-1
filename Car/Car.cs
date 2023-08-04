using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    abstract class Car
    {
        public string Brand { get; init; }
        public int Year { get; init; }
        public string Colour { get; set; }

        public Car(string brand, int year, string color)
        {
            Brand = brand;
            Year = year;
            Colour = color;
        }

        public virtual void show()
        {

        }

        public abstract void DriveCar();


    }
}
