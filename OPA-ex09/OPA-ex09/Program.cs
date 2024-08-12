using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA_ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro, raio, area;

            Console.WriteLine("Digite o diametro do circulo: ");
            diametro = double.Parse(Console.ReadLine());

            raio = diametro / 2;

            area = Math.PI * Math.Pow(raio,2);

            Console.WriteLine("O valor da area é de: " + Math.Round(area,2));

            Console.ReadKey();


        }
    }
}
