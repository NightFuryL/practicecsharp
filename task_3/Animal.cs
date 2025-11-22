using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_3
{
    internal abstract class Animal
    {
        public string Name { get; }
        public string Info { get; }
        public Animal(string name, string info)
        {
            Name = name;
            Info = info;
        }
        public abstract void DoSound();
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{Name}: {Info}");
            return sb.ToString();
        }
    }

}
