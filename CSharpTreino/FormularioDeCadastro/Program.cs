using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioDeCadastro
{
    class Program
    {
        static List<string> nome = new List<string>();
        static List<int> idade = new List<int>();
        static void Main(string[] args)
        {
            AdicionaNome();
            Console.ReadKey();
        }
        /// <summary>
        /// Este método solicita a inclusão de nomes
        /// </summary>
        private static void AdicionaNome()
        {
            Console.WriteLine("                                 ----------Seja bem-vindo----------");
            Console.WriteLine("Informe o nome do funcionário: ");
            nome.Add(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Deseja continuar incluindo nomes? sim(s) não(n)");
            var decisao = Console.ReadKey().KeyChar.ToString().ToLower();
            Console.Clear();
            if (decisao == "s")
                AdicionaNome();
        }
        private static void 
    }
}
