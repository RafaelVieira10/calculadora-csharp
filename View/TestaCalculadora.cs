using System;
using calculadora.Model;

namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("===========================");
            Console.WriteLine("      Calculadora");
            Console.WriteLine("===========================");

            while (true)
            {

                Console.WriteLine("[1] - Adição");
                Console.WriteLine("[2] - Substração");
                Console.WriteLine("[3] - Multiplicação");
                Console.WriteLine("[4] - Divisão");
                Console.WriteLine("[5] - Exponênciação");
                Console.WriteLine("[6] - Encerrar calculadora");

                Console.WriteLine("===========================");

                Console.Write("Qual operação deseja realizar: ");
                int operacao = Convert.ToInt32(Console.ReadLine());


                if (operacao == 6)
                {
                    Console.WriteLine("===========================");
                    System.Console.WriteLine("Encerrando calculadora");
                    Console.WriteLine("===========================");
                    break;
                }
                else {
                    Console.Write("Digite um número: ");
                    float num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite um número: ");
                    float num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("===========================");

                    switch (operacao)
                {
                    case 1:
                        calc.Somar(num1, num2);
                        Console.WriteLine("===========================");
                        break;
                    case 2:
                        calc.Subtrair(num1, num2);
                        Console.WriteLine("===========================");
                        break;
                    case 3:
                        calc.Multiplicar(num1, num2);
                        Console.WriteLine("===========================");
                        break;
                    case 4:
                        calc.Dividir(num1, num2);
                        Console.WriteLine("===========================");
                        break;
                    case 5:
                        calc.Exponenciar(num1, num2);
                        Console.WriteLine("===========================");
                        break;
                    default:
                        Console.WriteLine("Operação invalida");
                        Console.WriteLine("===========================");
                        break;
                    }
                }   
            }
        }
    }
}