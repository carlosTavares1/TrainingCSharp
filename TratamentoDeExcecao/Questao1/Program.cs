using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade > 18)
                throw new Exception("Já está acima da idade!");
            else
                Console.WriteLine("Menor que 18 anos.");
        }
    }
}
