using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TP3.Utils;

namespace TP3.Exercicios
{
    class Exercicio7
    {
        public void Executar()
        {
            LimpaConsole.Limpar();

            ContaBancaria cb1 = new ContaBancaria("João da Silva");
            cb1.Depositar(500);
            cb1.ExibirSaldo();

            cb1.Sacar(1000);
            cb1.Sacar(200);
            cb1.ExibirSaldo();

            Validacao.Validar();
        }
    }

    class ContaBancaria
    {
        public string titular { get; set; }
        private decimal saldo { get; set; }

        public ContaBancaria(string titular)
        {
            titular = titular;
            saldo = 0.0m;
            Console.WriteLine($"Titular: {titular}");
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado com sucesso");
            }
            else
            {
                Console.WriteLine($"O valor do depósito deve ser positivo!");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo:C}");
        }
    }
}

