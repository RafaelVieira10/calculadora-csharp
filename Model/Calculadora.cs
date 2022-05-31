using System;
namespace calculadora.Model
{
    public class Calculadora
    {
        

        public void Somar(float num1, float num2) {
            Console.WriteLine($"       {num1} + {num2} = {num1 + num2}");
        }

        public void Subtrair (float num1, float num2) {
            Console.WriteLine($"       {num1} - {num2} = {num1 - num2}");
        }

        public void Dividir (float num1, float num2) {
            Console.WriteLine($"       {num1} / {num2} = {num1 / num2}");
        }

        public void Multiplicar (float num1, float num2) {
            Console.WriteLine($"       {num1} x {num2} = {num1 * num2}");
        }

        public void Exponenciar (float num1, float num2) {
            Console.WriteLine($"       {num1} ^ {num2} = {Math.Pow(num1, num2)}");
        }
        
    }
}