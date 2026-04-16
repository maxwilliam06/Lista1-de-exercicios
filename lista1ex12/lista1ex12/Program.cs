using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, d = 0;
            int i = 1;

            while (i < 7)
            {
                if (i == 1)
                {
                    Console.Write("Digite o valor do produto 1: ");
                    n1 = float.Parse(Console.ReadLine());
                }
                else if (i == 2)
                {
                    Console.Write("Digite o valor do produto 2: ");
                    n2 = float.Parse(Console.ReadLine());
                }
                else if (i == 3)
                {
                    Console.Write("Digite o valor do produto 3: ");
                    n3 = float.Parse(Console.ReadLine());
                }
                else if (i == 4)
                {
                    Console.Write("Digite o valor do produto 4: ");
                    n4 = float.Parse(Console.ReadLine());
                }
                else if (i == 5)
                {
                    Console.Write("Digite o valor do produto 5: ");
                    n5 = float.Parse(Console.ReadLine());
                }
                else if (i == 6)
                {
                    Console.Write("Digite o quanto dinheiro para pagamento: ");
                    d = float.Parse(Console.ReadLine());
                }
                i++;
            }
            ;
            float t = d - (n1 + n2 + n3 + n4 + n4 + n5);
            Console.WriteLine("O troco será: {0:F2} R$", t);
            Console.ReadLine();
        }
    }
}
