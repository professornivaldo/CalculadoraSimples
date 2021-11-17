using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal resultado = Calculadora(1, 1);
            Console.WriteLine("O resultado é: " + resultado);
        }

        static decimal Calculadora(decimal valor1, decimal valor2)
        {
            return valor1 - valor2;
        }
    }
}
