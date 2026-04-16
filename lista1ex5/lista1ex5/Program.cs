using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, n3 = 0, n4 = 0;
            int i = 1;

            while (i < 5)
            {
                double tempnota = 0;

                Console.WriteLine("Digite a nota {0}: ", i);
                tempnota = double.Parse(Console.ReadLine());
                if (i == 1)
                    n1 = tempnota;
                else if (i == 2)
                    n2 = tempnota;
                else if (i == 3)
                    n3 = tempnota;
                else if (i == 4)
                    n4 = tempnota;

                i++;
            }
            ;
            Console.WriteLine("A média é {0}", (n1 + n2 + n3 + n4) / 4);


            Console.ReadLine();
        }
    }
}
