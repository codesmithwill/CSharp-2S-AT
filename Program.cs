using TP3.Exercicios;
using TP3.Utils;

namespace TP3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string opcao = "";

            while (opcao != "sair")
            {
                Console.WriteLine("/----------------------- AT - C# ----------------------/");
                Console.WriteLine("/");
                Console.WriteLine("/ 1  - Exercício 1        (Criando o Primeiro Programa)");
                Console.WriteLine("/ 2  - Exercício 2        (Cifrador de Nome)");
                Console.WriteLine("/ 3  - Exercício 3        (Calculadora de Operações Matemáticas)");
                Console.WriteLine("/ 4  - Exercício 4        (Dias até o Próximo Aniversário)");
                Console.WriteLine("/ 5  - Exercício 5        (Tempo para Conclusão do Curso)");
                Console.WriteLine("/ 6  - Exercício 6        (Cadastro de Alunos)");
                Console.WriteLine("/ 7  - Exercício 7        (Banco Digital - Encapsulamento)");
                Console.WriteLine("/ 8  - Exercício 8        (Cadastro de Funcionários - Herança)");
                Console.WriteLine("/ 9  - Exercício 9        (Controle de Estoque por Linha de Comando)");
                Console.WriteLine("/ 10 - Exercício 10       (Jogo de Advinhação)");
                Console.WriteLine("/ 11 - Exercício 11       (Cadastro e Listagem de Contatos)");
                Console.WriteLine("/ 12 - Exercício 12       (Formatos de Exibição)");
                Console.WriteLine("/");
                Console.WriteLine("/------------------------------------------------------/\n");
                Console.WriteLine("sair - para sair da aplicação\n");
                Console.Write("Digite a opção desejada: ");
                opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "1":
                        Exercicio1.Executar();
                        break;
                    case "2":
                        Exercicio2.Executar();
                        break;
                    case "3":
                        Exercicio3 ex3 = new Exercicio3();
                        ex3.Executar();
                        break;
                    case "4":
                        Exercicio4 ex4 = new Exercicio4();
                        ex4.Executar();
                        break;
                    case "5":
                        Exercicio5 ex5 = new Exercicio5();
                        ex5.Executar();
                        break;
                    case "6":
                        Exercicio6 ex6 = new Exercicio6();
                        ex6.Executar();
                        break;
                    case "7":
                        Exercicio7 ex7 = new Exercicio7();
                        ex7.Executar();
                        break;
                    case "8":
                        Exercicio8 ex8 = new Exercicio8();
                        ex8.Executar();
                        break;
                    case "9":
                        Exercicio9 ex9 = new Exercicio9();
                        ex9.Executar();
                        break;
                    case "10":
                        Exercicio10 ex10 = new Exercicio10();
                        ex10.Executar();
                        break;
                    case "11":
                        Exercicio11 ex11 = new Exercicio11();
                        ex11.Executar();
                        break;
                    case "12":
                        Exercicio12 ex12 = new Exercicio12();
                        ex12.Executar();
                        break;
                    case "sair":
                        LimpaConsole.Limpar();
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        LimpaConsole.Limpar();
                        Console.WriteLine("Opção inválida.\n");
                        break;
                }

            }
        }
    }
}