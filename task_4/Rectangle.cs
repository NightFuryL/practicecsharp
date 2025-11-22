using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_4
{
    internal class Rectangle : Figure
    {
        double w, h;
        public Rectangle(double w, double h) { this.w = w; this.h = h; }
        public override double Area() => w * h;
        public override double Perimeter() => 2 * (w + h);
    }
}
