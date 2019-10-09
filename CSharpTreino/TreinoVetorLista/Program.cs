using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoVetorLista
{
    class Program
    {
        static List<string> nome = new List<string>();
        static void Main(string[] args)
        {
            //CadastraFuncionarios();
            AdicionaItens();

            foreach (var item in nome)
            {
                Console.WriteLine($"\r\nO nome digitado foi: {item}");
            }

            Console.ReadKey();

            
        }
        /// <summary>
        /// Este método solicita os nomes dos funcionários e depois escreve eles
        /// </summary>
        private static void CadastraFuncionarios()
        {
            string[] vetor = new string[3];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Seja bem-vindo!");
                Console.WriteLine("Informe os nomes dos funcionários: ");
                vetor[i] = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine($"Os nomes digitados foram: {vetor[0]}, {vetor[1]} e {vetor[2]}");
            Console.ReadKey();
        }

        private static void AdicionaItens()
        {
            Console.WriteLine("Informe o nome do funcionário: ");
            nome.Add(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Voce deseja continuar incluindo? sim(s) não(n)");
            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
            {
                Console.Clear();
                AdicionaItens();
            }
            else
                Console.Clear();
        }
    }
}
