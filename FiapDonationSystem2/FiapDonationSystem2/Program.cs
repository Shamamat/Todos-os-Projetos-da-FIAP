using System.Security.Cryptography.X509Certificates;
using FiapDonationSystem2.Enum;
using FiapDonationSystem2.Model;

namespace FiapDonationSystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Calcado calcado = new Calcado();

            produto.Nome = "Matheus";
            Console.WriteLine(produto.Nome);

            produto.Descricao = "Uma pessoa muito estranha";
            Console.WriteLine(produto.Descricao);

            int valor = -5;
            if(valor < 0)
            {
                throw new Exception("Valor não pode ser menor que zero! Burrin");
            }

            // calcado.Tamanho = ETamanhoCalcado.Dez;


            //Roupa roupa = new Roupa();
            //Usuario user = new Usuario();
            //Produto prod = new Produto();

            //roupa.Categoria = ECategoria.Camisetas;
            //roupa.Tamanho = ETamanhoRoupa._4;




            //user.nome = "Meu nome é Robertin do Grau";
            //user.telefone = "96969-6969";
            //user.email = "Robertin.grau@hothot.com";
            //user.cadastro = "Meu cadastro é top";
            //user.descricao = "Eu tenho um milhão de dívidas, top";

            //prod.nome = "Sacola roubada";
            //prod.descricao = "Roubei do maninho ali da esquina";
            //prod.genero = "Plástico";
            //prod.foto = "Foto 3x4";
            //prod.status = true;

            //Console.WriteLine(user.ExibirDados());
            //Console.WriteLine(prod.ExibirDados());
        }
    }
}