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
    class Exercicio11
    {
        string caminhoArquivo = "contatos.txt";
        public void Executar()
        {
            LimpaConsole.Limpar();

            string opcao = "";

            string[] contatos;

            if (!File.Exists(caminhoArquivo))
            {
                File.Create(caminhoArquivo).Close();
            }

            while (!opcao.Equals("3"))
            {
                Console.WriteLine("\n/------------- MENU -------------/");
                Console.WriteLine("/ 1. Adicionar novo contato");
                Console.WriteLine("/ 2. Listar contatos cadastrados");
                Console.WriteLine("/ 3. Sair do menu");
                Console.WriteLine("/--------------------------------/\n");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        InserirContatos();
                        break;
                    case "2":
                        ListarContatos();
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

        public void InserirContatos()
        {
            LimpaConsole.Limpar();
            Console.Write("Nome do Contato: ");
            string nome = Console.ReadLine();

            Console.Write("Telefone do Contato: ");
            string telefone = Console.ReadLine();

            Console.Write("E-mail do contato: ");
            string email = Console.ReadLine();

            string contato = $"{nome},{telefone},{email}";

            using (StreamWriter sw = File.AppendText(caminhoArquivo))
            {
                sw.WriteLine(contato);
            }

            Console.WriteLine("Contato inserido.");
            Console.ReadKey();
            LimpaConsole.Limpar();
        }

        public void ListarContatos()
        {
            if (new FileInfo(caminhoArquivo).Length == 0)
            {
                Console.WriteLine("\nNenhum contato cadastrado.");
                Console.ReadKey();
                LimpaConsole.Limpar();
                return;
            }

            LimpaConsole.Limpar();

            Console.WriteLine("Contatos cadastrados:");

            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] dados = linha.Split(',');

                    string nome = dados[0];
                    string telefone = dados[1];
                    string email = dados[2];

                    Console.WriteLine($"Nome: {nome} | " +
                        $"Telefone: {telefone} | " +
                        $"E-mail: {email}");
                }
            }
            Console.ReadKey();
            LimpaConsole.Limpar();
        }
    }
}

