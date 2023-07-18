using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem2
{
    internal class Usuario : IAutenticavel
    {
        public string nome;
        public string telefone;
        public string email;
        public string senha;
        public string apelido;

        public string ExibirDados()
        {
            return "Dados do Usuário: \nNome: " + nome + "\nTelefone: "+ telefone + "\nE-mail: "
                + email + "\nSenha: " + senha + "\nApelido: " + apelido;
        }
    }
}
