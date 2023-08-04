using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Malibu : Car
    {
        public static int Passengers { get; set; }
        public readonly int _maxSpeed;
        public string Brand { get; set; }

        public Malibu(int passemgers, int maxSpeed, string brand, int year, string color)
            : base (brand, year, color)
        {
            Passengers = passemgers;
            _maxSpeed = maxSpeed;
            base.Brand = brand;
            this.Brand = brand;
        }
        public override void DriveCar()
        {
            throw new NotImplementedException();
        }
    }
}
