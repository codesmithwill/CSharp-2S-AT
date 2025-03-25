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
    class Exercicio9
    {
        string caminhoArquivo = "estoque.txt";
        public void Executar()
        {
            LimpaConsole.Limpar();

            string opcao = "";

            string[] produtos = new string[5];
            int contadorProdutos = 0;

            if (!File.Exists(caminhoArquivo))
            {
                File.Create(caminhoArquivo).Close();
            }

            while (!opcao.Equals("3"))
            {
                Console.WriteLine("\n/------------- MENU -------------/");
                Console.WriteLine("/ 1. Inserir Produto");
                Console.WriteLine("/ 2. Listar Produtos");
                Console.WriteLine("/ 3. Sair do menu");
                Console.WriteLine("/--------------------------------/\n");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        if (contadorProdutos < 5)
                        {
                            InserirProduto(ref contadorProdutos);
                        }
                        else
                        {
                            Console.WriteLine("Limite de 5 produtos atingido!");
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        ListarProdutos();
                        break;
                    case "3":
                        Console.WriteLine("\nSaindo do menu.");
                        break;
                    default:
                        LimpaConsole.Limpar();
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            Console.ReadKey();
            LimpaConsole.Limpar();
        }

        public void InserirProduto(ref int contadorProdutos)
        {
            LimpaConsole.Limpar();
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade em Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Preço unitário: ");
            double preco = double.Parse(Console.ReadLine());

            string produto = $"{nome},{quantidade},{preco:F2}";

            using (StreamWriter sw = File.AppendText(caminhoArquivo))
            {
                sw.WriteLine(produto);
            }

            contadorProdutos++;
            Console.WriteLine("Produto inserido com sucesso.");
            Console.ReadKey();
            LimpaConsole.Limpar();
        }

        public void ListarProdutos()
        {
            if (new FileInfo(caminhoArquivo).Length == 0)
            {
                Console.WriteLine("\nNenhum produto cadastrado.");
                Console.ReadKey();
                return;
            }

            LimpaConsole.Limpar();

            Console.WriteLine("Produtos cadastrados:");

            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] dados = linha.Split(',');

                    string nome = dados[0];
                    int quantidade = int.Parse(dados[1]);
                    double preco = double.Parse(dados[2]);

                    Console.WriteLine($"Produto: {nome} | " +
                        $"Quantidade: {quantidade} | " +
                        $"Preço: R$ {preco:F2}");
                }
            }
            Console.ReadKey();
            LimpaConsole.Limpar();
        }
    }
}

