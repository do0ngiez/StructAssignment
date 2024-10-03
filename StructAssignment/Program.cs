using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    struct Number
    {
        public decimal Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 187.29m;

            Console.WriteLine("Amount: $" + number.Amount);
            Console.ReadLine();
        }
    }
}
