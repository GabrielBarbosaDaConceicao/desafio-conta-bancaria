using System;
using System.Globalization;

namespace Desafio_Conta_Bancaria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TextInfo text = CultureInfo.CurrentCulture.TextInfo;

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            titular = text.ToTitleCase(titular);

            Console.Write("Haverá deposito inicial [S/N]? ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 'S' || resposta == 's')
            {
                Console.Write("Entre com o valor para deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine($"\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre com um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("\nEntre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}