using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoBanco
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public override void Saca(double valorOperacao)
        {
            Saldo -= valorOperacao;
        }
        public override void Deposita(double valorOperacao)
        {
            Saldo += valorOperacao;
        }
        /// <summary>
        /// Este método calcula o tributo
        /// </summary>
        /// <returns>Ele retorna o produto do saldo por 0.02</returns>
        public double CalcularTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
