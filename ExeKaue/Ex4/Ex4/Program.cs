using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float num3;
            float media;
            Console.WriteLine("insira uma nota");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira outra nota");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira outra nota");
            num3 = int.Parse(Console.ReadLine());
            media = (num1 + num2 + num3) / 3;
            if (media >= 7)
            {
                Console.WriteLine("nota {0} aprovado",media);
            }
            else
            {
                Console.WriteLine("nota {0} reprovado",media);
            }
        }
    }
}
