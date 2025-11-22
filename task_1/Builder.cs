using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_1
{
    internal class Builder : Human
    {
        public string Position { get; }
        public Builder(string name, int age, string position) : base(name, age)
        {
            Position = position;
        }
        public override void DoWork() => Console.WriteLine($"Будівельник {Name} будує!");
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Builder: {Name}, {Age}, {Position}");
            return sb.ToString();
        }
    }

}
