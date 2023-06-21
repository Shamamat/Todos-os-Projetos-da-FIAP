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

                if (emailLogin.Equals("admin@fiap.com.br"))
                {
                    if (senhaLogin.Equals("admin123"))
                    {
                        Console.WriteLine($"Bem-vindo ao sistema usuário de e-mail: {emailLogin}");
                    }
                    else
                    {
                        Console.WriteLine("Usuário e/ou senha inválidos!");
                    }
                }
               
            }
            else
            {
                Console.WriteLine("Obrigado por usar!");
            }
        }
    }
}