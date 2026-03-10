using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("insira um numero");
            num = int.Parse(Console.ReadLine());
            num = num * 2;
            Console.WriteLine("{0}",num);
        }
    }
}
