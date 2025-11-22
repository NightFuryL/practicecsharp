using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_4
{
    internal class Circle : Figure
    {
        double r;
        public Circle(double r) { this.r = r; }
        public override double Area() => Math.PI * r * r;
        public override double Perimeter() => 2 * Math.PI * r;
    }
}
