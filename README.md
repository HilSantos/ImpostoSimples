# ImpostoSimples
Crie um programa que leia o salário mensal de uma pessoa e calcule um imposto simples de 10% se o salário for maior que R$ 3000,00. Caso contrário, informe que não há imposto. Exiba o valor do imposto ou a mensagem "Isento".

using System;

namespace CalculadoraImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário o salário mensal
            Console.WriteLine("Digite o salário mensal:");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

  // Verifica se o salário é maior que R$ 3.000,00
            if (salario > 3000)
            {
                // Calcula o imposto de 10%
                decimal imposto = salario * 0.10m;

  // Exibe o valor do imposto
                Console.WriteLine($"Valor do imposto: {imposto.ToString("C")}");
            }
            else
            {
  // Exibe a mensagem "Isento"
                Console.WriteLine("Isento");
            }
        }
    }
}
