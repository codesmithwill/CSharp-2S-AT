using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TP3.Utils;

namespace TP3.Exercicios
{
    class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }

    abstract class ContatoFormatter
    {
        public abstract void ExibirContatos(List<Contato> contatos);
    }

    class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            LimpaConsole.Limpar();
            Console.WriteLine("## Lista de Contatos \n");
            foreach (var contato in contatos)
            {
                Console.WriteLine($"**{contato.Nome}**\n" +
                    $"📞 Telefone: {contato.Telefone}\n" +
                    $"📧 E-mail: {contato.Email}\n");
            }
        }
    }

    class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            LimpaConsole.Limpar();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("| Nome           | Telefone       |   E-mail       |");
            Console.WriteLine("----------------------------------------------------");
            foreach (var contato in contatos)
            {
                Console.WriteLine($"| {contato.Nome,-14} | {contato.Telefone,-14} | {contato.Email,-14} |");
            }
            Console.WriteLine("----------------------------------------------------");
        }
    }

    class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            LimpaConsole.Limpar();
            foreach (var contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone} | E-mail: {contato.Email}");
            }
        }
    }
    class Exercicio12
    {
        string caminhoArquivo = "contatos.txt";
        public void Executar()
        {
            LimpaConsole.Limpar();

            if (!File.Exists(caminhoArquivo))
            {
                File.Create(caminhoArquivo).Close();
            }

            string opcao = "";
            while (!opcao.Equals("3"))
            {
                LimpaConsole.Limpar();
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
                        EscolherFormato();
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
            List<Contato> contatos = CarregarContatos();

            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                Console.ReadKey();
                LimpaConsole.Limpar();
                return;
            }
            Console.WriteLine("Contatos carregados.");
        }

        public void EscolherFormato()
        {
            List<Contato> contatos = CarregarContatos();

            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                Console.ReadKey();
                LimpaConsole.Limpar();
                return;
            }
            Console.WriteLine("\nEscolha o formato de exbição: ");
            Console.WriteLine("1. Markdown");
            Console.WriteLine("2. Tabela");
            Console.WriteLine("3. Texto");
            Console.Write("Opção desejada: ");

            string opcao = Console.ReadLine();

            ContatoFormatter formatter = opcao switch
            {
                "1" => new MarkdownFormatter(),
                "2" => new TabelaFormatter(),
                "3" => new RawTextFormatter(),
            };

            if (formatter != null)
            {
                formatter.ExibirContatos(contatos);
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            Console.ReadLine();
        }

        private List<Contato> CarregarContatos()
        {
            List<Contato> contatos = new List<Contato>();
            if (new FileInfo(caminhoArquivo).Length == 0) return contatos;

            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] dados = linha.Split(",");
                    contatos.Add(new Contato { Nome = dados[0], Telefone = dados[1], Email = dados[2] });
                }
            }
            return contatos;
        }
    }
}

