using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA_ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotaçãodolar, valordolar, valorreal;

            Console.WriteLine("Digite o valor da cotação do dolar: ");
            cotaçãodolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que deseja converter de dolar para real: ");
            valordolar = double.Parse(Console.ReadLine());

            valorreal = valordolar * cotaçãodolar;

            Console.WriteLine("$" + valordolar +" " + "Dolares é igual a R$" + valorreal);

            Console.ReadKey();
        }
    }
}
