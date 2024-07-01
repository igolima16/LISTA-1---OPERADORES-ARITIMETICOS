using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1 = -1;

            
            while (p1 < 0)
            {
                Console.Write("Digite a nota da P1 (valor positivo): ");
                p1 = Convert.ToDouble(Console.ReadLine());

                if (p1 < 0)
                {
                    Console.WriteLine("Nota inválida. Por favor, digite um valor positivo.");
                }
            }

            
            double mediaAprovacao = 5.0;

            
            double p2Necessaria = (3 * mediaAprovacao - p1) / 2;

            
            Console.WriteLine($"Para ser aprovado, você precisa tirar pelo menos {p2Necessaria:F2} na P2.");
        }
    }
}
