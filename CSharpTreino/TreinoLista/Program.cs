using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> conjuntoOrdenado = new SortedSet<string>();

            conjuntoOrdenado.Add("Marcos");
            conjuntoOrdenado.Add("Gabriel");
            conjuntoOrdenado.Add("Carlos");
            conjuntoOrdenado.Add("Davi");

            foreach (var item in conjuntoOrdenado)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
