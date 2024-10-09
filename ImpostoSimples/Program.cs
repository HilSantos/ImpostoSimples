using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoSimples
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal salario, imposto;

            Console.WriteLine("Informe o valor do seu salário: ");
            salario = decimal.Parse(Console.ReadLine());

            if (salario >= 3000)
            {
                imposto = salario * 10 / 100;
                salario = salario + imposto;
                Console.WriteLine("Salario com 10% de imposto: " + salario.ToString("C"));
            }
            else if (salario <= 2999)
            {
                Console.WriteLine("Voce é isento! Salario" +salario.ToString("C"));
            }
            Console.ReadKey();
        }
    }
}
