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
    class Exercicio8
    {
        public void Executar()
        {
            LimpaConsole.Limpar();

            Console.WriteLine("Funcionário:\n");
            Funcionario funcionario = new Funcionario();
            funcionario.nome = "Willian da Silva";
            funcionario.cargo = "Analista de RH";
            funcionario.salarioBase = 1000m;
            funcionario.ExibirDados();

            Console.WriteLine("\nGerente:");
            Gerente gerente = new Gerente();
            gerente.nome = "Orlando Fonseca";
            gerente.cargo = "Professor de C#";
            gerente.salarioBase = 5000m;
            gerente.ExibirDados();

            Validacao.Validar();
        }
    }

    class Funcionario
    {
        public string nome;
        public string cargo;
        public decimal salarioBase;

        public void ExibirDados()
        {
            Console.WriteLine($"Nome do funcionário: {nome}");
            Console.WriteLine($"Cargo do funcionário: {cargo}");
            Console.WriteLine($"Salário Base: {salarioBase:C}");
        }
    }

    class Gerente : Funcionario
    {
        public double bonus = 0.20;
        
        public decimal CalcularSalarioTotal()
        {
            return salarioBase + (salarioBase * (decimal)bonus);
        }

        public new void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Salário Total com Bônus: {CalcularSalarioTotal():C}");
        }
    }
}

