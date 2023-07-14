using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiapDonationSystem2.Enum;

namespace FiapDonationSystem2.Model
{
    internal class Calcado : Produto
    {
        public String Material { get; set; }
        public ETamanhoCalcado Tamanho { get; set; }
        public ECategoriaCalcado Categoria { get; set; }
        public ETipoAjuste TipoAjuste { get; set; }

        public void exibeDados()
        {

        }


    }
}
