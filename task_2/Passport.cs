using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_2
{
    internal class Passport
    {
        public string FullName { get; }
        public int Number { get; }
        public Passport(string fullName, int number)
        {
            FullName = fullName;
            Number = number;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Passport: {FullName}, {Number}");
            return sb.ToString();
        }
    }

}
