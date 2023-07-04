namespace FiapDonationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, telefone, email, senha, apelido;
            Console.WriteLine("Bem vindo ao FIAP Donation System!");

            Console.Write("\n 1 - Registrar um novo usuário \n2 - Logar \n3 - Sair \n= Digite a opção desejada! =");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {

                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite seu telefone: ");
                telefone = Console.ReadLine();

                Console.WriteLine("Digite seu e-mail: ");
                email = Console.ReadLine();

                Console.WriteLine("Digite sua senha: ");
                senha = Console.ReadLine();

                Console.WriteLine("Digite seu apelido: ");
                apelido = Console.ReadLine();
            }

            else if (opcao == 2) {

                Console.WriteLine("Digite seu e-mail: ");
                string emailLogin = Console.ReadLine();

                Console.WriteLine("Digite sua senha: ");
                string senhaLogin = Console.ReadLine();

                    if (senhaLogin.Equals("admin123") && senhaLogin.Equals("admin123"))
                    {
                        Console.WriteLine($"Bem-vindo ao sistema usuário de e-mail: {emailLogin}");
                    }
                    else
                    {
                        Console.WriteLine("Usuário e/ou senha inválidos!");
                    }


               
            }
            else
            {
                Console.WriteLine("Obrigado por usar!");
            }



            //Campo de Doações:

            Console.WriteLine($"\nBem-vindo ao campo de doações do ONG! Aqui você sinaliza pra nóis se você ta");
            Console.WriteLine($"trabalhando mesmo ou não! Você passará por todas essas 12 opções abaixo: \n ");
            Console.WriteLine($"||====================================================================================||");
            Console.WriteLine($"|| 1 - Declarar número de doações no mês ||");
            Console.WriteLine($"|| 2 - Declarar o valor de cada doação ||");
            Console.WriteLine($"|| 3 - Verificar o total de doações ||");
            Console.WriteLine($"|| 4 - Verificar se o número de doações é maior que R$ 10.000,00 ||");
            Console.WriteLine($"|| 5 - Declarar o número de projetos realizados no mês ||");
            Console.WriteLine($"|| 6 - Verificar se o número de projetos é igual ou maior que três ||");
            Console.WriteLine($"|| 7 - Calcular a média de valor das doações por projeto ||");
            Console.WriteLine($"|| 8 - Verificar a média do de valor das doações por projeto com duas casas decimais ||");
            Console.WriteLine($"|| 9 - Verificar a quantidade de doações recebidas ||");
            Console.WriteLine($"|| 10 - Calcular a média das doações recebidas ||");
            Console.WriteLine($"|| 11 - Calcular a média das doações recebidas por projeto ||");
            Console.WriteLine($"|| 12 - Calcular a média das doações recebidas ||");
            Console.WriteLine($"||===================================================================================||");

            // 1 - Doações recebidas no Mês

            int DoacoesMes, i;
            double valorDoado, TotalDoacoes = 0;

            Console.WriteLine($"Informe o valor de doações recebidas no mês: ");
            DoacoesMes = Convert.ToInt32(Console.ReadLine());

            // 2 - Valor de cada doação informada acima

            for (i = 1; i <= DoacoesMes; i++)
            {
                Console.WriteLine($"Informe o valor da {i} doação: ");
                Console.ReadLine();
                DoacoesMes += i;
            }

            // 3 - Valor total das doações

            TotalDoacoes = Convert.ToDouble(DoacoesMes.ToString("0.00"));
            Console.WriteLine($"o número total de doações é {TotalDoacoes}");


        }
    }
}