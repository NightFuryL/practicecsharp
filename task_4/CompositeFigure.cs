using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_4
{
    internal class CompositeFigure
    {
        List<Figure> figures = new();
        public void Add(Figure f) => figures.Add(f);
        public double Area()
        {
            double s = 0;
            foreach (var f in figures) s += f.Area();
            return s;
        }
    }

}
