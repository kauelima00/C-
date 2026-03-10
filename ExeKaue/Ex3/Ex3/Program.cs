using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultado;
            Console.WriteLine("insira um numero");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("insira outro numero");
            num2=int.Parse(Console.ReadLine());
            resultado = num1 + num2;
            Console.WriteLine("Seu resultado foi "+ resultado);
        }
    }
}
