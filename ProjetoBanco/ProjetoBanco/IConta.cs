using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal interface IConta
    {
        public int Numero { get; set; }
        public Double Saldo { get; set; }
        public Double Depositar { get; set; }
        public Agencia Agencia { get; set; }
        public double Valor { get; set; }

        public abstract void depositar(double valor);

        public abstract void Sacar(double valor);
        public double exibeSaldo()
        {
            double taxaOperacao = Saldo -= Valor;
            return taxaOperacao;
        }
    }
}
