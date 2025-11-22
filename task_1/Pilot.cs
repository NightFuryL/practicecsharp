using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_1
{
    internal class Pilot : Human
    {
        public int Flights { get; }
        public Pilot(string name, int age, int flights) : base(name, age)
        {
            Flights = flights;
        }
        public override void DoWork() => Console.WriteLine($"Пілот {Name} летить!");
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Pilot: {Name}, {Age}, Flights: {Flights}");
            return sb.ToString();
        }
    }

}
