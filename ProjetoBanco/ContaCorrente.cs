using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoBanco
{
    public class ContaCorrente : Conta, ITributavel
    {
        public double CalcularTributo()
        {
            return this.Saldo * 0.05;
        }
        public override void Saca(double valorOperacao)
        {
            if (valorOperacao < 0)
                throw new ArgumentException();
            else if (Saldo < valorOperacao)
                throw new SaldoInsuficienteException();
            else
                Saldo -= valorOperacao;
        }
        public override void Deposita(double valorOperacao)
        {
            Saldo += valorOperacao;
        }
    }
}
