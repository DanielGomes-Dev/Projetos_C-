using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args = null)
        {
            Console.Clear();
            short selectedOption = Menu();
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (selectedOption)
            {
                case 1: Soma(valor1, valor2); break;
                case 2: Subtracao(valor1, valor2); break;
                case 3: Divisao(valor1, valor2); break;
                case 4: Multiplicacao(valor1, valor2); break;
                default: Main(); break;
            }

        }

        static short Menu()
        {

            Console.WriteLine("Calculadora: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("----------------------------");
            Console.Write("Selecione um Opção: ");
            short optionSelected = short.Parse(Console.ReadLine());
            if (optionSelected == 0) System.Environment.Exit(0);
            if (optionSelected < 0 || optionSelected > 4) Main();
            return optionSelected;

        }

        static void Soma(float valor1, float valor2)
        {
            float resultado = valor1 + valor2;

            // Console.WriteLine("O Resultado da Soma é: " + resultado);
            // Console.WriteLine("O Resultado da Soma é: " + (valor1 + valor2));
            Console.WriteLine($"O Resultado da Soma é: {resultado}");
            // Console.WriteLine($"O Resultado da Soma é: {valor1 + valor2}");
        }

        static void Subtracao(float valor1, float valor2)
        {
            float resultado = valor1 - valor2;
            Console.WriteLine($"O Resultado da Subtração é: {resultado}");

        }

        static void Divisao(float valor1, float valor2)
        {
            float resultado = valor1 / valor2;
            Console.WriteLine($"O Resultado da Divisão é: {resultado}");

        }

        static void Multiplicacao(float valor1, float valor2)
        {
            float resultado = valor1 * valor2;
            Console.WriteLine($"O Resultado da Multiplicação é: {resultado}");

        }

    }
}
