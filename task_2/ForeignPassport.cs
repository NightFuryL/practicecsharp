using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp.task_2
{
    internal class ForeignPassport : Passport
    {
        public int ForeignNumber { get; }
        public List<string> Visas { get; private set; }
        public ForeignPassport(string fullName, int number, int foreignNumber, List<string> visas)
            : base(fullName, number)
        {
            ForeignNumber = foreignNumber;
            Visas = visas;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"ForeignPassport: {FullName}, {Number}, {ForeignNumber}, Visas: {string.Join(", ", Visas)}");
            return sb.ToString();
        }
    }


}
