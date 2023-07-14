using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem2
{
    internal class Produto
    {
        public string Nome { get; set; }
        public string Descricao;
        public string Genero { get; set; }
        public string Foto { get; set; }
        public Boolean Status { get; set; }

        public string ExibirDados()
        {
            return "\n- Os dados do produto são:  \nNome: " + Nome + "\nDescrição: " + Descricao + "\nGênero: " + Genero 
                + "\nFoto: " + Foto + "\nStatus: " + Status;
        }
    }
}
