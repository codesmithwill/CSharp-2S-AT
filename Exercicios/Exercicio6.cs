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
    class Exercicio6
    {
        public void Executar()
        {
            LimpaConsole.Limpar();
            Aluno al1 = new Aluno();
            al1.Nome = "Nathalia Silva";
            al1.Matricula = 332141;
            al1.Curso = "Arquitetura";
            al1.MediaDasNotas = 8;
            al1.ExibirDados();

            Validacao.Validar();
        }
    }

    public class Aluno
    {
        public string Nome;
        public int Matricula;
        public string Curso;
        public int MediaDasNotas;

        public void ExibirDados()
        {
            if (Nome == null)
            {
                Nome = "Não informado(a)";
            }

            if (Curso == null)
            {
                Curso = "Não informado(a)";
            }

            Console.WriteLine("/---------------- INFORMAÇÕES ----------------/\n/");
            Console.WriteLine($"/ Nome do aluno: {Nome}");
            Console.WriteLine($"/ Matrícula do aluno: {Matricula}");
            Console.WriteLine($"/ Curso do aluno: {Curso}");
            Console.WriteLine($"/ Média do Aluno: {MediaDasNotas}");
            Console.Write($"/ Situação do aluno: ");
            VerificarAprovacao(MediaDasNotas);
            Console.WriteLine("/\n/---------------------------------------------/");
        }

        public void VerificarAprovacao(int media)
        {
            if (media > 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
        }
    }
}

