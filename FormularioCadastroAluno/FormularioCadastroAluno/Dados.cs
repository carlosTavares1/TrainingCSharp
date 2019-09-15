using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioCadastroAluno
{
    public class Dados
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int idade;
        
        public int PegaIdade(int indice)
        {
            switch (indice)
            {
                case 0:
                    this.idade = 14;
                    break;
                case 1:
                    this.idade = 15;
                    break;
                case 2:
                    this.idade = 16;
                    break;
                case 3:
                    this.idade = 17;
                    break;
                case 4:
                    this.idade = 18;
                    break;
                case 5:
                    this.idade = 19;
                    break;
                case 6:
                    this.idade = 20;
                    break;
                case 7:
                    this.idade = 21;
                    break;
                case 8:
                    this.idade = 22;
                    break;
                case 9:
                    this.idade = 23;
                    break;
                case 10:
                    this.idade = 24;
                    break;
                case 11:
                    this.idade = 25;
                    break;
                case 12:
                    this.idade = 26;
                    break;
                case 13:
                    this.idade = 27;
                    break;
                case 14:
                    this.idade = 28;
                    break;
                case 15:
                    this.idade = 29;
                    break;
                case 16:
                    this.idade = 30;
                    break;
                default:
                    this.idade = 31;
                    break;
            }
            return idade;
        }
	}
}
