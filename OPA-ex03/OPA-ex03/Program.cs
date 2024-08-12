using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA_ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diagonal, lado, area;

            Console.WriteLine("Digite o valor da diagonal do quadrado: ");
            diagonal = double.Parse(Console.ReadLine());

            lado = diagonal/Math.Sqrt(2);

            area = Math.Pow(lado, 2);

            Console.WriteLine("O valor da sua área é: " + area);


            Console.ReadKey();
        }
    }
}
