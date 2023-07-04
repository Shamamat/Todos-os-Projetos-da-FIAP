namespace MétodosFunções
{
    internal class Program
    {
        static double SomaNumeros(double n1, double n2)
        {
            double soma = n1 + n2;
            Console.WriteLine(soma);
            return soma;
        }

        static double SubtracaoNumeros(double n1, double n2)
        {
            double soma = n1 - n2;
            Console.WriteLine(soma);
            return soma;
        }

        static double DivisaoNumeros(double n1, double n2)
        {
            double soma = n1 / n1;
            Console.WriteLine(soma);
            return soma;
        }

        static double MultiplicacaoNumeros(double n1, double n2)
        {
            double soma = n1 * n2;
            Console.WriteLine(soma);
            return soma;
        }

        static void MenuOpcoes()
        {
            Console.WriteLine("+---+-----------------+");
            Console.WriteLine("| 1 |     Adição      |");
            Console.WriteLine("| 2 |    Subtração    |");
            Console.WriteLine("| 3 |  Multiplicação  |");
            Console.WriteLine("| 4 |     Divisão     |");
            Console.WriteLine("| 5 |      Sair       |");
            Console.WriteLine("+---+-----------------+");
        }

        static void Main(string[] args)
        {
            double n1, n2, res;
            int option;

            Console.WriteLine("Calculadora \n\n");
            Console.WriteLine("Digite o primeiro valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação que deseja!");

            do {
                MenuOpcoes();

                Console.Write("Código da operação: ");
                option = int.Parse(Console.ReadLine());

                
                
                switch (option)
                {
                    case 1:
                        Console.Write("A soma dos valores: " + n1 + " + " + n2 + " é = ");
                        SomaNumeros(n1, n2);
                        break;

                    case 2:
                        Console.Write($"A subtração dos valores {n1} - {n2} é = ");
                        res = n1 - n2;
                        Console.WriteLine(res);
                        break;

                    case 3:
                        Console.Write($"A multiplicação dos valores {n1} * {n2} é = ");
                        res = n1 * n2;
                        Console.WriteLine(res);
                        break;

                    case 4:
                        if (n1 != 0 || n1 == 0)
                        {
                            Console.Write($"A divisão dos valores {n1} / {n2} é = ");
                            res = n1 / n2;
                            Console.WriteLine(res);
                        }
                        else
                        {
                            Console.WriteLine("Impossivel dividir número por zero.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Obrigado por usar a calculadora! Não volte mais.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (option != 5);
        }
    }
}