using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class SeguroDeVida : ITributavel
    {
        public double CalcularTributo()
        {   
            TotalizadorDeTributos t = new TotalizadorDeTributos();
            return t.Total += 48;
        }
    }
}
