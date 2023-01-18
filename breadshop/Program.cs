using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breadshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string buyer;
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            buyer = Console.ReadLine();
            Console.WriteLine($"Noted: {buyer} got the bread.");
            Console.ReadLine();
        }
    }
}
