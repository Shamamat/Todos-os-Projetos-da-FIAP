using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem2
{
    internal class Produto
    {
        public string nome;
        public string descricao;
        public string genero;
        public string foto;
        public Boolean status;


        public string ExibirDados()
        {
            return "\n- Os dados do produto são:  \nNome: " + nome + "\nDescrição: " + descricao + "\nGênero: " + genero 
                + "\nFoto: " + foto + "\nStatus: " + status;
        }
    }
}
