using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_4
{
    internal class Rhombus : Figure
    {
        double d1, d2, side;
        public Rhombus(double d1, double d2, double side)
        {
            this.d1 = d1;
            this.d2 = d2;
            this.side = side;
        }
        public override double Area() => (d1 * d2) / 2;
        public override double Perimeter() => 4 * side;
    }

}
