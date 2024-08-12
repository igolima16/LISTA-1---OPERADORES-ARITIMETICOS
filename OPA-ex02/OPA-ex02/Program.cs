using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA_ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;

            Console.WriteLine("Digite um numero: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 == valor2)
                Console.Write("Os numero digitados são iguais");

            else
                if (valor1 > valor2)
                Console.Write("O primeiro valor é maior");

            else
                Console.Write("O segundo valor é maior");

            Console.ReadKey();
        }
    }
}
