using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace Seguros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vida vida = new Vida();
            vida.DataContratacao = DateTime.Today;
            vida.TipoPlano = "Básico";
            vida.valor = 2000;

            Veiculo veiculo = new Veiculo();

            GerenciadorImpostoRenda gir = new GerenciadorImpostoRenda();
            gir.Total = 1000;
            gir.adicionar(vida);

            Console.WriteLine("Valor total do IR: " + gir.Total);
        }
    }
}