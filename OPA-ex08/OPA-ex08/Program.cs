using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA_ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.WriteLine("Digite a temperatura a ser convertida de celsius para fahrenheit: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine("O valor convertido de celsius para fahrenheit é de; " + fahrenheit);

            Console.ReadKey();
        }
    }
}
