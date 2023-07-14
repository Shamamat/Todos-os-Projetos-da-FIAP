using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class ControladorDeExtratos
    {
        public void GeradorExtratos(IConta conta)
        {
            Console.WriteLine(CC.exibirSaldo()); 

        }
    }
}
