namespace Aula_4___Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo do While que ela passou aula passada (o Rafa que fez esse, tem frufru)

            Console.WriteLine("+---+----------------+");
            Console.WriteLine("| 1 |  Inserir Aluno |");
            Console.WriteLine("| 2 |      Sair      |");
            Console.WriteLine("+---+----------------+");

            Console.Write("Insira sua opção: ");
            int option = Convert.ToInt32(Console.ReadLine());

            while (option != 2)
            {
                Console.Write("Insira quantidade de alunos: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                int age, i = 1, sum = 0;
                double average;

                while (i <= quantity)
                {
                    Console.Write("Insira a idade do aluno " + i + ":");
                    age = Convert.ToInt32(Console.ReadLine());
                    sum += age;
                    i++;
                }
                average = sum / quantity;
                Console.WriteLine("A média de idade dos alunos é: " + average);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("+---+----------------+");
                Console.WriteLine("| 1 |  Inserir Aluno |");
                Console.WriteLine("| 2 |      Sair      |");
                Console.WriteLine("+---+----------------+");

                Console.Write("Insira sua opção: ");
                option = Convert.ToInt32(Console.ReadLine());
            }

            // Exercício 1:

            int i, fat = 1, numero;
            Console.WriteLine("Digite um número para calcular o fatorial: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (i = numero; i > 1; i--)
            {
                fat*= i;
                Console.WriteLine($"{numero}");
            } // NÃO TERMINEI!!!
            

        }
    }
}