using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> lista = new List<Conta>();
            Conta c1 = new Conta();
            Conta c2 = new Conta();
            lista.Add(c1);
            lista.Add(c2);
            int contador = lista.Count;
            Console.WriteLine(contador);
            lista.ForEach(i => Console.WriteLine(i.Numero));
            bool temC2 = lista.Contains(c2);
            Console.WriteLine(temC2);
            lista.Remove(c2);
            bool temC22 = lista.Contains(c2);
            Console.WriteLine(temC22);
            lista.ForEach(i => Console.WriteLine(i.Numero));

            Console.ReadKey();
        }
    }
}
