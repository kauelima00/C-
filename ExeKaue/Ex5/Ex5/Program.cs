using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celsius;
            int fehrenheit;
            Console.WriteLine("insira uma temperatura em celsius");
            celsius = int. Parse(Console.ReadLine());
            fehrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine("Fehrenheit {0}",fehrenheit);
        }
    }
}
