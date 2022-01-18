using System;
using System.Globalization;

namespace Desafio_Conta_Bancaria
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) //double saldo
        {
            Numero = numero;
            Titular = titular;
            //Saldo = 0.0;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return ($"Conta: {Numero}, Titular: {Titular}, Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}