using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7___Basico_de_OO
{
    internal class Editora
    {
        public string nome;
        public string resumo;
        public double valor;
        public int paginas;
        public string autor;

        public string ExibirDados()
        {
            Console.WriteLine(nome);
            return nome;
        }
    }


}
