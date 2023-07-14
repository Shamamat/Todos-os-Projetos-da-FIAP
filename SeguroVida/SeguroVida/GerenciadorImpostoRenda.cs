using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros
{
    internal class GerenciadorImpostoRenda
    {
        public double Total { get; set; }

        public void adicionar(ITributavel trib)
        {
            this.Total += trib.calcularImposto();
        }


    }
}
