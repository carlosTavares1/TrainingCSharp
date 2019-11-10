using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeNumerosAleatórios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>() {"carlos", "marcio", "jose" };
            var tamanho = nomes.Count;
            Random r = new Random();
            var sorteio = r.Next(0, tamanho);
            Console.WriteLine(nomes[sorteio]);            

            Console.ReadKey();
        }
    }
}
