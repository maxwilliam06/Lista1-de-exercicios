using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;

            Console.WriteLine("Digite o valor da base do triângulo: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do triângulo: ");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine("A área do triângulo é {0}", (b * h) / 2);
            Console.ReadLine();
        }
    }
}
