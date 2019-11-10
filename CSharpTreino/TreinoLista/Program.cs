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
            List<string> nome = new List<string>();

            nome.Add("carlos");
            nome.Add("caio");
            nome.Add("jose");
            nome.Add("marcos");
            nome.Add("carlos");

            (from c in nome where c != "carlos" select c).ToList<string>().ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    }
}
