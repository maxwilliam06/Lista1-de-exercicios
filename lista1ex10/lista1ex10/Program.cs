using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float c;
            float v;

            Console.WriteLine("Qual a cotação do dólar desejada: ");
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a o valor de dólares: ");
            v = float.Parse(Console.ReadLine());

            Console.WriteLine("A conversão será: {0} R$", c * v);
            Console.ReadLine();
        }
    }
}
