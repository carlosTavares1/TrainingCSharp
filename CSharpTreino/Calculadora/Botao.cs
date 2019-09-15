using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Botao
    {
        public double resultado = 0;
        public int b0 = 0;
        public int b1 = 1;
        public int b2 = 2;
        public int b3 = 3;
        public int b4 = 4;
        public int b5 = 5;
        public int b6 = 6;
        public int b7 = 7;
        public int b8 = 8;
        public int b9 = 9;

        /// <summary>
        /// Este método realiza a soma dos valores digitados
        /// </summary>
        public void Soma()
        {
            switch (resultado)
            {
                case 0:
                    resultado = 0;
                    break;
                case 1:
                    resultado = 1;
                    break;
                case 2:
                    resultado = 2;
                    break;
                case 3:
                    resultado = 3;
                    break;
                case 4:
                    resultado = 4;
                    break;
                case 5:
                    resultado = 5;
                    break;
                case 6:
                    resultado = 6;
                    break;
                case 7:
                    resultado = 7;
                    break;
                case 8:
                    resultado = 8;
                    break;
                default:
                    resultado = 9;
                    break;
            }
        }
    }
}
