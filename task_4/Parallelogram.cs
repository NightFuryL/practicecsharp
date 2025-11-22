using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_4
{
    internal class Parallelogram : Figure
    {
        double a, b, h;
        public Parallelogram(double a, double b, double h) { this.a = a; this.b = b; this.h = h; }
        public override double Area() => a * h;
        public override double Perimeter() => 2 * (a + b);
    }
}
