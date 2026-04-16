using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("A temperatura em Fahrenheit é {0} graus Fahrenheit", (c * 1.9) + 32);
            Console.ReadLine();
        }
    }
}
