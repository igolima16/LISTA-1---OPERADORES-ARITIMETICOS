using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA_ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double produto1, produto2, produto3, produto4, produto5, somaproduto, pagamentoproduto, trocoproduto;

            Console.WriteLine("Digite o valor do 1º produto");
            produto1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do 2º produto");
            produto2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do 3º produto");
            produto3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do 4º produto");
            produto4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do 5º produto");
            produto5 = double.Parse(Console.ReadLine());

            somaproduto = produto1 + produto2+ produto3 + produto4 + produto5;

            Console.WriteLine(" A soma dos 5 produtos é: " + somaproduto);

            Console.WriteLine("Digite o valor de pagamento");
            pagamentoproduto = double.Parse(Console.ReadLine());

            trocoproduto = somaproduto - pagamentoproduto;

            if (pagamentoproduto > somaproduto )
            {
                Console.WriteLine("O troco é de: " + "R$" + trocoproduto);
            }

            else
            if (somaproduto > pagamentoproduto)
            {
                Console.WriteLine("O valor não é suficiente, falta " + "R$" + Math.Abs (trocoproduto));
            }
            else
            {
                Console.WriteLine("O valor está correto, Muito obrigado");
            }

            Console.ReadKey();
        }
    }
}
