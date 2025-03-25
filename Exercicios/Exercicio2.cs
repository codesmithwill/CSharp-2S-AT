using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Utils;

namespace TP3.Exercicios
{
    class Exercicio2
    {
        public static void Executar() { 
            LimpaConsole.Limpar();

            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine().ToLower();
            // fiz em ToLower pois seria mais facil sem ter que pegar
            // o código ASCII para letra maiúscula.
            // até porque, o exercicio não especifica o formato que deve ser
            ConverterChar(nome);

            Validacao.Validar();
        }

        public static void ConverterChar(string nome)
        {
            char[] caracteres = nome.ToCharArray();
            // cria uma lista com os caracteres do nome
            
            foreach (char c in caracteres)
            {
                if (c >= 'a' && c <= 'z')
                {
                    char novoCaractere = DeslocarLetra(c);
                    // cria uma nova string com cada letra deslocada.
                    Console.Write(novoCaractere);
                }
                else
                {
                    Console.Write(c);
                }
            }
        }

        public static char DeslocarLetra(char letra)
        {
            return (char)((letra - 'a' + 2) % 26 + 'a');
        }
    }
}
