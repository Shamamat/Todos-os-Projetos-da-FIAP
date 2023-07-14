using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class ContaPoupança
    {
        public void depositar(double valor)
        {
            base.Saldo = +valor;
        }

        public void Sacar(double valor)
        {
            base.Saldo = -valor;
        }

        public double exibirSaldo()
        {
            return this.Saldo;
        }
    }
}
