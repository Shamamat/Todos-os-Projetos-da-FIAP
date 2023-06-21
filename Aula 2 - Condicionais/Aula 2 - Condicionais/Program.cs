namespace Aula_2___Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if(idade > 12)
            {
                Console.WriteLine("Você pode jogar!");
            }
            else
            {
                Console.WriteLine("Você não pode jogar!");
            }

            double doacao, investimento;
            doacao = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe o valor da doação: R$");

            if(doacao >= 1000)
            {
                investimento = doacao * 0.1;
            }
            else
            {
                investimento = doacao * 0.5;
            }

            Console.WriteLine($"O valor informado foi ${doacao} com o desconto " +
                $"de ${investimento} que vai pra doação, obrigado por sua contribuição!");

            // ------------

            double doacaoMes;
            
            Console.WriteLine("Coloque o valor da doação mensal: ");
            doacaoMes = Convert.ToDouble(Console.ReadLine());

            if(doacaoMes >= 10000)
            {
                Console.WriteLine("As doações foram o suficiente!");
            }
            else
            {
                Console.WriteLine("As doações foram um lixo! Demitido.");
            }

        }
    }
}