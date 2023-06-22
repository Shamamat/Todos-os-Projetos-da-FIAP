using System;

namespace Aula_3___Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


            if(mediaFinal >= 7 && frequencia > 75) //não terminei! (prof mt rápida, slc)
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