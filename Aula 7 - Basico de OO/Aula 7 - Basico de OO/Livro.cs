using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7___Basico_de_OO
{
    internal class Livro
    {

        protected string Nome;
        public string Resumo;
        public double Valor;
        public string Autor;
        public int Paginas;


        public Livro()
        {

        }

        public Livro(string nome)
        {
            this.Nome = nome;
        }

        public Livro(string nome, string resumo, string autor, double valor, int paginas, Editora editora)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.Valor = valor;
            this.Resumo = resumo;
            this.Paginas = paginas;
            this.Editora = Editora;
        }
    }
}
