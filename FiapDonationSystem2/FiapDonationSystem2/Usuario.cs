using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem2
{
    internal class Usuario
    {
        public string nome;
        public string telefone;
        public string email;
        public string cadastro;
        public string descricao;

        public string ExibirDados()
        {
            return "Dados do Usuário: \nNome: " + nome + "\nDescrição: "+ descricao + "\nE-mail: "
                + email + "\nCadastro: " + cadastro + "\nDescrição: " + descricao;
        }
    }
}
