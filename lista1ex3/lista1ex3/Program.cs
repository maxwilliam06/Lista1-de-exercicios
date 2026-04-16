using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;

            Console.WriteLine("Digite o valor da diagonal do quadrado: ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("A área do quadrado é {0}", (d * d) / 2);
            Console.ReadLine();
        }
    }
}
