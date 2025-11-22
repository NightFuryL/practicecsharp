using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_4
{
    internal class Ellipse : Figure
    {
        double a, b;
        public Ellipse(double a, double b) { this.a = a; this.b = b; }
        public override double Area() => 3.14 * a * b;
        public override double Perimeter() => 3.14 * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
    }

}
