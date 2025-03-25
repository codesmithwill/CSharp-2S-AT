using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Utils;

namespace TP3.Exercicios
{
    class Exercicio3
    {
        double n1; 
        double n2; 
        double calculo; 
        
        string entrada;
        int opcao;

        public void Executar() {
            LimpaConsole.Limpar();

            Console.Write("Digite o primeiro número (não podendo ser 0): ");
            entrada = Console.ReadLine();
            opcao = 0;

            while(!double.TryParse(entrada, out n1) || n1 < 1)
            {
                if (entrada.Any(char.IsLetter))
                {
                    Console.WriteLine("\nERRO: Apenas números a partir de 1.");
                }
                else
                {
                    Console.WriteLine("\nERRO: Digite um número maior que 0.");
                }
                Console.Write("Digite o prímeiro número: ");
                entrada = Console.ReadLine();
            }

            Console.Write("Digite o primeiro número (não podendo ser 0): ");
            entrada = Console.ReadLine();

            while (!double.TryParse(entrada, out n2) || n2 < 1)
            {
                if (entrada.Any(char.IsLetter))
                {
                    Console.WriteLine("\nERRO: Apenas números a partir de 1.");
                }
                else
                {
                    Console.WriteLine("\nERRO: Digite um número maior que 0.");
                }
                Console.Write("Digite o prímeiro número: ");
                entrada = Console.ReadLine();
            }

            while(opcao < 1 || opcao > 4) {
                Console.WriteLine("\n/----------- OPERAÇÕES MATEMÁTICAS -----------/");
                Console.WriteLine("/ 1 - Soma                                    /");
                Console.WriteLine("/ 2 - Subtração                               /");
                Console.WriteLine("/ 3 - Multiplicação                           /");
                Console.WriteLine("/ 4 - Divisão                                 /");
                Console.WriteLine("/---------------------------------------------/\n");
                Console.Write("Digite a opção desejada: ");

                entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out opcao) || opcao < 1 || opcao > 4)
                {
                    Console.WriteLine("\nERRO: Digite uma opção válida entre 1 e 4.");
                }

                switch (opcao)
                {
                    case 1:
                        Somar(n1, n2);
                        CalcularNovamente();
                        break;
                    case 2:
                        Subtrair(n1, n2);
                        CalcularNovamente();
                        break;
                    case 3:
                        Multiplicar(n1, n2);
                        CalcularNovamente();
                        break;
                    case 4:
                        Dividir(n1, n2);
                        CalcularNovamente();
                        break;
                    default:
                        Console.WriteLine("ERRO.");
                        break;
                }
            }
        }
        public void Somar(double n1, double n2)
        {
            calculo = n1 + n2;
            Console.WriteLine($"\nA soma de: {n1} + {n2} é: {calculo}");
        }

        public void Subtrair(double n1, double n2)
        {
            calculo = n1 - n2;
            Console.WriteLine($"\nA subtração de: {n1} - {n2} é: {calculo}");
        }

        public void Multiplicar(double n1, double n2)
        {
            calculo = n1 * n2;
            Console.WriteLine($"\nA multiplicação de: {n1} x {n2} é: {calculo}");
        }

        public void Dividir(double n1, double n2)
        {
            calculo = n1 / n2;
            Console.WriteLine($"\nA divisão de: {n1} ÷ {n2} é: {calculo}");
        }

        public void CalcularNovamente()
        {
            string verificar = "";

            while(verificar != "s" && verificar != "n") {
                Console.WriteLine("Deseja realizar outra operação?" +
                    " 's' para sim" +
                    " 'n' para voltar ao menu.");

                verificar = Console.ReadLine().ToLower();

                if (verificar == "s")
                {
                    Executar();
                } else if (verificar == "n")

                {
                    LimpaConsole.Limpar();
                    break;
                }

                Console.WriteLine("\nERRO: Resposta deve ser apenas 's' ou 'n'.");
            }
        }
    }
}
