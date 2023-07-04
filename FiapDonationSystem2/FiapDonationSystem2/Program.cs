namespace FiapDonationSystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            Produto prod = new Produto();

            user.nome = "Meu nome é Robertin do Grau";
            user.telefone = "96969-6969";
            user.email = "Robertin.grau@hothot.com";
            user.cadastro = "Meu cadastro é top";
            user.descricao = "Eu tenho um milhão de dívidas, top";

            prod.nome = "Sacola roubada";
            prod.descricao = "Roubei do maninho ali da esquina";
            prod.genero = "Plástico";
            prod.foto = "Foto 3x4";
            prod.status = true;

            Console.WriteLine(user.ExibirDados());
            Console.WriteLine(prod.ExibirDados());
        }
    }
}