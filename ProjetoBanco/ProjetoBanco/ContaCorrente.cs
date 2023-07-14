using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class ContaCorrente : IConta
    {
        public override void depositar(double valor)
        {
            base.Saldo =+ valor;
        }

        public override void Sacar(double valor)
        {
            base.Saldo =- valor;
        }

        public double exibirSaldo()
        {
            return this.Saldo;
        }
    }
}
