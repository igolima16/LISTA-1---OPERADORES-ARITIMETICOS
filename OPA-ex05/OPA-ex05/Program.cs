using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA_ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, resultado;

            Console.WriteLine("Digite o 1º numero: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º numero: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 3º numero: ");
            num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 4º numero: ");
            num4 = double.Parse(Console.ReadLine());

            resultado = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("A Média entre os 4 numeros é: " + resultado);

            Console.ReadKey();


        }
    }
}
