using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TP3.Utils;

namespace TP3.Exercicios
{
    class Exercicio10
    {
        public void Executar()
        {
            LimpaConsole.Limpar();
            Random numAleatorio = new Random();
            int minimo = 1;
            int maximo = 50;
            int numero = numAleatorio.Next(minimo, maximo + 1);

            int tentativas = 5;

            Console.WriteLine("/----------- JOGO DE ADVINHAÇÃO -----------/");
            Console.WriteLine($"/ Tente adivinhar o número de {minimo} á {maximo}");
            Console.WriteLine($"/ Você tem um total de {tentativas} tentativa(s).");
            Console.WriteLine("/------------------------------------------/");
            //Console.WriteLine(numero);

            while (tentativas > 0)
            {
                Console.WriteLine($"\nTentativa(s) Restante(s): {tentativas}");
                Console.Write($"Tente adivinhar o número: ");

                if (!int.TryParse(Console.ReadLine(), out int palpite))
                {
                    Console.WriteLine("ERRO: Digite um número inteiro.");
                    continue;
                }

                if (palpite < minimo || palpite > maximo)
                {
                    Console.WriteLine($"\nNúmero fora do intervalo, digite um número entre {minimo} e {maximo}.");
                    continue;
                }

                tentativas--;

                if (palpite == numero)
                {
                    Console.WriteLine("\n/------------------------------------------/");
                    Console.WriteLine("\nParabéns! Você acertou o número!");
                    Console.WriteLine($"O número era: {numero}\n");
                    Console.WriteLine("/------------------------------------------/");
                    Console.ReadKey();
                    LimpaConsole.Limpar();
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{palpite} é {(palpite > numero ? "maior" : "menor")} que o número gerado.");
                }

                if (tentativas == 0)
                {
                    Console.WriteLine("\n/------------------------------------------/");
                    Console.WriteLine($"\nVocê excedeu suas tentativas!");
                    Console.WriteLine($"O número era: {numero}.\n");
                    Console.WriteLine("/------------------------------------------/");
                    Console.ReadKey();
                    LimpaConsole.Limpar();
                    break;
                }
            }

        }
    }
}

