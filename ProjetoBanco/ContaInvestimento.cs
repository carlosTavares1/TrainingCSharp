using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class ContaInvestimento : Conta, ITributavel
    {
        public double CalcularTributo()
        {
            return this.Saldo * 0.03;
        }
        public override void Deposita(double valorOperacao)
        {
            Saldo += valorOperacao;
        }
        public override void Saca(double valorOperacao)
        {
            Saldo -= valorOperacao;
        }
    }
}
