using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            LeituraEscrita();
        }
        /// <summary>
        /// Este método faz a leituras de quatro nomes e depois os retorna.
        /// </summary>
        private static void LeituraEscrita()
        {
            string[] nome = new string[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Informe o nome: ");
                nome[i] = Console.ReadLine();
                Console.Clear();
            }

            foreach (string name in nome)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
