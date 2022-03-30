using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("ESCOLHA COMO DESEJA CRONOMETRAR");
            Console.WriteLine("[1] - CRESCENTE");
            Console.WriteLine("[2] - DECRESCENTE");

            string choice = Console.ReadLine();

            if (choice == "1")
                Crescente();
            else
                Decrescente();


        }
        static void Crescente()
        {
            Console.Clear();
            Console.WriteLine("PARA INICILIZAR O CRONÔMETRO SELECIONE O TEMPO + PARÂMETRO DE TEMPO");
            Console.WriteLine("[S] - SEGUNDOS (EXEMPLO: 10s - SEGUNDOS)");
            Console.WriteLine("[M] - MINUTOS  (EXEMPLO: 1m - MINUTOS)");
            Console.WriteLine("[F] - FECHAR");
            Console.WriteLine("");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplayer = 1;

            if (type == 'm')
                multiplayer = 60;

            if (time == 'f')
                System.Environment.Exit(0);

            PreStart(time * multiplayer);

        }

        static void Decrescente()
        {
            Console.Clear();
            Console.WriteLine("PARA INICILIZAR O CRONÔMETRO SELECIONE O TEMPO + PARÂMETRO DE TEMPO");
            Console.WriteLine("[S] - SEGUNDOS (EXEMPLO: 10s - SEGUNDOS)");
            Console.WriteLine("[M] - MINUTOS  (EXEMPLO: 1m - MINUTOS)");
            Console.WriteLine("[F] - FECHAR");
            Console.WriteLine("");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplayer = 1;

            if (type == 'm')
                multiplayer = 60;

            if (time == 'f')
                System.Environment.Exit(0);

            UnPreStart(time * multiplayer);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Read...");
            Thread.Sleep(1500);
            Console.WriteLine("Set...");
            Thread.Sleep(1500);
            Console.WriteLine("GO!!");
            Thread.Sleep(2500);

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
            Console.WriteLine("Stopwatch Finalizado!");
            Thread.Sleep(2500);
            Menu();
        }

        static void UnPreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Read...");
            Thread.Sleep(1500);
            Console.WriteLine("Set...");
            Thread.Sleep(1500);
            Console.WriteLine("GO!!");
            Thread.Sleep(2500);

            UnStart(time);
        }

        static void UnStart(int time)
        {

            int currentTime = time;

            while (currentTime > 0)
            {
                Console.Clear();
                currentTime--;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Stopwatch Finalizado!");
            Thread.Sleep(2500);
            Menu();
        }

    }

}