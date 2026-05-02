using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            // Start(10);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("StopWatch");
            Console.WriteLine("");
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m =  1 Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("");
            Console.WriteLine("Quanto Tempo deseja Contar? ");

            string data = Console.ReadLine().ToLower();
            int time = int.Parse(data.Substring(0, data.Length - 1));
            char type = char.Parse(data.Substring(data.Length - 1, 1));

            int multplier = 1;

            if (type == 'm') multplier = 60;
            if (time == 0) System.Environment.Exit(0);

            PreStart(time * multplier);


        }

        static void PreStart(int time)
        {
            Console.Clear();

            Console.WriteLine("Ready.....");
            Thread.Sleep(1000);

            Console.WriteLine("Set.....");
            Thread.Sleep(1000);

            Console.WriteLine("Go.....");
            Thread.Sleep(500);

            Start(time);


        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch Finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }


}
