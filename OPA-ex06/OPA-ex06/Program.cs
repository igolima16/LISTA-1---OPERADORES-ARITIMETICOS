using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA_ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;

            Console.WriteLine("Digite o 1º numero: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º numero: ");
            num2 = double.Parse(Console.ReadLine());        

            resultado = Math.Sqrt(num1 + num2 );

            Console.WriteLine("O valor da média geométrica é: " + Math.Round(resultado,2));

            Console.ReadKey();

        }
    }
}
