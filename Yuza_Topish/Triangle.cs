﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuza_Topish
{
    internal class Triangle
    {
        public Triangle(double a, double b, double c)
        {
            if (!IsValidArgs(a, b, c))
                throw new ArgumentException("Uchburchak shartlarini qanoatlantirmaydi:");
            A = a;
            B = b;
            C = c;
        }

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public double Perimetr{ get => A + B + C; }
        public double Area 
        {
            get
            {

                var p = Perimetr / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
         }
        private bool IsValidArgs(double a, double b, double c)
        {
            return a<b < c
        }
    }
}
