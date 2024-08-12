using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA_ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int basedotriangulo, alturadotriangulo;
            double area;

            Console.WriteLine("Digite o valor da base do triangulo: ");
            basedotriangulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do triangulo: ");
            alturadotriangulo = int.Parse(Console.ReadLine());

            area = (alturadotriangulo * basedotriangulo);

            Console.WriteLine("A area do triangulo é: " +  area);

            Console.ReadKey();


        }
    }
}
