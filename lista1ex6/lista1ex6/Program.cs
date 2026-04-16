using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1 = 0, v2 = 0;

            Console.WriteLine("Digite o primeiro valor: ");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("A média geométrica dos valores é {0}", Math.Sqrt(v1 * v2));
            Console.ReadLine();
        }
    }
}
