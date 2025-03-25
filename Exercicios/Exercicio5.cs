using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TP3.Utils;

/*
 * 1. Quanto tempo falta para a formatura? (anos, meses e dias)
 * 
 * 2. Se faltar menos de 6 meses, mensagem: 
 * " A reta final chegou! Prepare-se para a formatura!"
 *
 * 3. Se a data de formatura já tiver passado, mensagem:
 * " Parabéns! Você já deveria estar formado! "
*/


namespace TP3.Exercicios
{
    class Exercicio5
    {
        public void Executar()
        {
            LimpaConsole.Limpar();

            DateTime dataFormatura = new DateTime(2026, 12, 15);
            DateTime dataAtual = DateTime.Now;

            Console.Write("Digite a data atual (dd/MM/yyyy): ");
            string entrada = Console.ReadLine();

            if (DateTime.TryParseExact(entrada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataUsuario))
            {
                if (dataUsuario.Date != dataAtual.Date)
                // irá verificar se a data digitada é igual a data atual
                {
                    Console.WriteLine("\nERRO: A data digitada não é a data atual.");
                    Validacao.Validar();
                    return;
                }

                TimeSpan dif = dataFormatura - dataUsuario;
                int anos = dif.Days / 365;
                int meses = (dif.Days % 365) / 30;
                int dias = (dif.Days % 365) % 30;

                if (dif.Days < 180)
                {
                    Console.WriteLine($"\nFaltam {meses} mese(s) e {dias} dia(s) para a sua formatura.");
                    Console.WriteLine("A reta final chegou! Prepare-se para a formatura.");
                }
                else if (dataUsuario < dataFormatura)
                {
                    Console.WriteLine($"\nFaltam {anos} ano(s), {meses} mese(s) e {dias} dia(s) para a sua formatura.");
                }
                else if (dataUsuario > dataFormatura)
                {
                    Console.WriteLine("Parabéns você já deveria estar formado!");
                }
                else
                {
                    Console.WriteLine("\nHoje é o dia da sua formatura! Parabéns!");
                }
            } 
            else
            {
                Console.WriteLine("\nERRO: Data inválida");
            }
            Validacao.Validar();
        }
    }
}
