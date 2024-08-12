using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorx, valory, resultado;

            Console.WriteLine("Digite o valor da base");
            valorx = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do expoente");
            valory = double.Parse(Console.ReadLine());

            resultado = Math.Pow(valorx, valory);

            Console.WriteLine("O valor da base elevada ao expoente é " + resultado);

            Console.ReadKey();
        }
    }
}
