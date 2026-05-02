using System;
using System.Globalization;

namespace moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var valor = 10.25;
            decimal valorD = 10.25m;

            Console.WriteLine(valor);
            Console.WriteLine(valorD);

            var pt = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");

            Console.WriteLine(valor.ToString("G",en));

            Console.WriteLine(valor.ToString("C",pt));
            Console.WriteLine(valor.ToString("C",en)); //
            var valor2 = 10.182487238747832387947892389748972397843289749782378942397878942978432978432987;
            Console.WriteLine(valor2.ToString("E04",en));
            Console.WriteLine(valor2.ToString("F",en));
            Console.WriteLine(valor2.ToString("N",en)); //
            Console.WriteLine(valor2.ToString("P",en)); //
            Console.WriteLine(Math.Round(valor2));
            Console.WriteLine(Math.Ceiling(valor2));
            Console.WriteLine(Math.Floor(valor2));


            var valor3 = 10;

        }
    }
}
