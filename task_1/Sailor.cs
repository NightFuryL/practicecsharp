using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_1
{
    internal class Sailor : Human
    {
        public string Rank { get; }
        public Sailor(string name, int age, string rank) : base(name, age)
        {
            Rank = rank;
        }
        public override void DoWork() => Console.WriteLine($"Моряк {Name} пливе!");
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Sailor: {Name}, {Age}, {Rank}");
            return sb.ToString();
        }
    }

}
