using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_4
{
    internal class Trapezoid : Figure
    {
        double a, b, h;
        public Trapezoid(double a, double b, double h) { this.a = a; this.b = b; this.h = h; }
        public override double Area() => (a + b) / 2 * h;
        public override double Perimeter() => 0;
    }

}
