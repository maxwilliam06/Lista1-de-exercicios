using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;

            Console.WriteLine ("Informe a base do Retângulo:");
            b= int.Parse (Console.ReadLine());

            Console.WriteLine("Informe a altura do Retângulo:");
            h = int.Parse (Console.ReadLine());

            Console.WriteLine("A área do Retângulo é ");
            a = b * h;
            Console.WriteLine(a);


        }
    }
}
