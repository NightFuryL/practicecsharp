using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_1
{
    abstract class Human
    {
        public string Name { get; }
        public int Age { get; }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void DoWork();
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{Name}, {Age}");
            return sb.ToString();
        }
    }
}
