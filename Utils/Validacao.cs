using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Utils
{
    class Validacao
    {
        public static void Validar()
        {
            Console.WriteLine("\nDigite 'sair' para voltar ao menu principal.");
            string entrada = Console.ReadLine();

            while(!entrada.Equals("sair"))
            {
                Console.WriteLine("\nERRO: Entrada inválida.");
                Console.WriteLine("\nDigite 'sair' para voltar ao menu principal.");
                entrada = Console.ReadLine();
            }

            if (entrada.Equals("sair"))
            {
                Console.Clear();
            }
        }    
    }
}
