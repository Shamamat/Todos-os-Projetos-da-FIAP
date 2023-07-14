using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7___Basico_de_OO
{
    internal class LivroFisico : Livro
    {
        public string Capa { get; set; }
        public LivroFisico(string nome, string resumo, string autor, double paginas, string valor) : base(nome, resumo, autor, paginas, valor);

        public override void exibirDados()
        {
            base.exibirDados;
            Console.WriteLine("Capa: " + Capa);
        } 
    }
}
