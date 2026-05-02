using System;

namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 100;
            float real = 25.8F;
            // inteiro = real;
            //real = inteiro;
            //inteiro = (int)real;
            string valor_real = inteiro.ToString();
            inteiro = int.Parse(valor_real);


            Console.WriteLine("Hello World!");
            Console.WriteLine(inteiro);
            Console.WriteLine(real);

        }
    }
}
