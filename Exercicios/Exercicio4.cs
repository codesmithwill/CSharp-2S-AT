using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Utils;

namespace TP3.Exercicios
{
    class Exercicio4
    {
        public void Executar()
        {
            LimpaConsole.Limpar();

            Console.Write("Digite o dia do seu nascimento (1-31): ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Digite o mês do seu nascimento (ex: 5,8,12): ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano do seu nascimento (ex: 2000, 2001): ");
            int ano = int.Parse(Console.ReadLine());

            DateTime dataNasc = new DateTime(ano, mes, dia);
            DateTime dataAtual = DateTime.Now;;

            DateTime anivNesseAno = new DateTime(dataAtual.Year, mes, dia);
            DateTime proxAniv;

            if (anivNesseAno < dataAtual)
            {
                proxAniv = new DateTime(dataAtual.Year + 1, mes, dia);
            }
            else
            {
                proxAniv = anivNesseAno;
            }

            TimeSpan diferenca = proxAniv - dataAtual;
            int diasRestantes = diferenca.Days;

            Console.WriteLine($"\nFaltam {diasRestantes} dia(s) para o seu próximo aniversário");

            if (diasRestantes < 7)
            {
                Console.WriteLine($"\nEita! Seu aniversário está próximo!");
            }

                Validacao.Validar();
        }
    }
}
