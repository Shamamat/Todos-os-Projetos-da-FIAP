namespace Aula_2___Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, digite as 3 notas do aluno para fazer a média aritmética: ");

            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if(media < 4)
            {
                Console.WriteLine($"Sua nota foi ${media}, logo, você está Reprovado!");
            }

            else if (media > 7)
            {
                Console.WriteLine($"Sua nota foi ${media}, logo, você está Aprovado!");
            }

            if (media > 4 || media < 7)
            {
                Console.WriteLine("$Sua nota foi ${media}, logo, você está Em Prova Final!");
            }

        }
    }
}