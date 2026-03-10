using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dolar;
            float reais;
            Console.WriteLine("Digite um valor em dolar");
            dolar = float.Parse(Console.ReadLine());
            reais = dolar * 5.14f;
            Console.WriteLine("{0} reais",reais);
        }
    }
}
