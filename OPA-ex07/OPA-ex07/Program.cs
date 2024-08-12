using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA_ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double milhasmaritimas, resultado;

            Console.WriteLine("Digite a quantidade de milhas marítimas para converter para quilometros: ");
            milhasmaritimas = double.Parse(Console.ReadLine());

            resultado = milhasmaritimas * 1852;

            Console.WriteLine("A quantidade de milhas maritimas é: " + resultado);

            Console.ReadKey();
        }
    }
}
