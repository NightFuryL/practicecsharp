using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_3
{
    internal class Crocodile : Animal
    {
        public Crocodile(string name, string info) : base(name, info) { }
        public override void DoSound() => Console.WriteLine("Crocodile: GRRR");
    }


}
