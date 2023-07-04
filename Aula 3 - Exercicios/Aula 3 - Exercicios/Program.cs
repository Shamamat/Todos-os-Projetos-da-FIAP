using System;

namespace Aula_3___Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1 - extra do pdf:

            Console.WriteLine("selecione a operação desejada");
            Console.WriteLine("+---+----------------+");
            Console.WriteLine("| 1 |     Depósito   |");
            Console.WriteLine("| 2 |      Saque     |");
            Console.WriteLine("| 3 |     Ver Saldo  |");
            Console.WriteLine("| 4 |      Sair      |");
            Console.WriteLine("+---+----------------+");
            Console.Write("Insira sua opção: ");
            int option = int.Parse(Console.ReadLine());

            double saldo = 0;

            while (option != 4)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Você escolheu depósito.");
                        Console.Write("Quanto deseja depositar R$:");
                        double valorDeposito = double.Parse(Console.ReadLine());
                        saldo += valorDeposito;

                        Console.WriteLine("Você depositou " + valorDeposito);
                        Console.Write("Insira sua opção: ");
                        option = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor do saque: R$");
                        double valorSaque = double.Parse(Console.ReadLine());

                        if (valorSaque <= saldo)
                        {
                            saldo -= valorSaque;
                            Console.WriteLine("Você sacou " + valorSaque);
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        Console.Write("Insira sua opção: ");
                        option = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Saldo atual: R$" + saldo);

                        Console.Write("Insira sua opção: ");
                        option = int.Parse(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Código inválido!");


                        Console.Write("Insira sua opção: ");
                        option = int.Parse(Console.ReadLine());
                        break;
                }
            }

            // Exercício 2 - extra do pdf:

            int numeroMes;
            Console.WriteLine("Digite um número de 1 a 12 para saber o mês escolhido!");
            numeroMes = Convert.ToInt32(Console.ReadLine());

            switch (numeroMes)
            {
                case 1:
                    Console.WriteLine($"O número 1 é o mês de Janeiro!");
                    break;

                case 2:
                    Console.WriteLine("O número 2 é o mês de Fevereiro!");
                    break;

                case 3:
                    Console.WriteLine("O número 3 é o mês de Março!");
                    break;

                case 4:
                    Console.WriteLine("O número 4 é o mês de Abril!");
                    break;

                case 5:
                    Console.WriteLine("O número 5 é o mês de Maio!");
                    break;

                case 6:
                    Console.WriteLine("O número 6 é o mês de Junho!");
                    break;

                case 7:
                    Console.WriteLine("O número 7 é o mês de Julho!");
                    break;

                case 8:
                    Console.WriteLine("O número 8 é o mês de Agosto!");
                    break;

                case 9:
                    Console.WriteLine("O número 9 é o mês de Setembro!");
                    break;

                case 10:
                    Console.WriteLine("O número 10 é o mês de Outubro!");
                    break;

                case 11:
                    Console.WriteLine("O número 11 é o mês de Novembro!");
                    break;

                case 12:
                    Console.WriteLine("O número 12 é o mês de Dezembro!");
                    break;

                default:
                    Console.WriteLine("O número inserido é invalidadadasso, você é... bobo!");
                    break;
            }

            // Exercício 1

            double compra, compraDesconto = 0;
            string cupom;

            Console.WriteLine("Digite o total de compras do usuário: ");
            compra = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o cumpom de desconto: ");
            cupom = Console.ReadLine();

            if (compra > 1000 || cupom.Equals("DESCONTO20"))
            {
                compraDesconto = compra - compra * 0.2;

                Console.WriteLine($"Total da compra: {compra}\nDesconto: " +
                $"{cupom} \n Valor total da compra com desconto: R${compraDesconto}");
            }

            Console.WriteLine($"Total da compra: {compra}\nDesconto: " +
                $"{cupom} \n Valor sem desconto");

            // Exercício 2 ------

            int numeroPlaca;

            Console.WriteLine("Digite o número final de sua placa para passar por uma validação: ");
            numeroPlaca = Convert.ToInt32(Console.ReadLine());
            int finalPlaca = numeroPlaca % 10;

            switch(finalPlaca)
            {
                case 1:
                case 2: Console.WriteLine("Você não pode andar com o carro na segunda!");
                    break;

                case 3:
                case 4: Console.WriteLine("Você não pode andar com o carro na terça!");
                    break;

                case 5:
                case 6: Console.WriteLine("Você não pode andar com o carro na quarta!");
                    break;

                case 7:
                case 8: Console.WriteLine("Você não pode andar com o carro na quinta!");
                    break;

                case 9:
                case 0: Console.WriteLine("Você não pode andar com o carro na sexta!");
                    break;
            }


            // -- Outro exercício

            double nota1, nota2, mediaFinal, frequencia;

            Console.WriteLine("Digite sua primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            mediaFinal = nota1 + nota2 / 2;


            // if(mediaFinal >= 7 && frequencia > 75) //não terminei! (prof mt rápida, slc)
            {
                Console.WriteLine("Parabéns, você foi aprovado!");
            }

            // exercício 3 - triângulos

            double lado1, lado2, lado3;

            Console.WriteLine("Digite o primeiro lado do triângulo: ");
            lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado do triângulo: ");
            lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado do triângulo: ");
            lado3 = Convert.ToDouble(Console.ReadLine());

            if(lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
                if(lado1 == lado2 && lado1 == lado3) //isóseles
                {
                    Console.WriteLine("Triângulo Equilatero");
                }
                else if(lado1 != lado2 && lado1 != lado3) 
                {
                    Console.WriteLine("Triângulo isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo escaleno"); 
                }
            }
            else
            {
                Console.WriteLine("O triângulo não existe! Seu Burrão...");
            }
            
        }
    }
}