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
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0= Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data =Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length -1));

            int multiplier = 1;

            if (type == 'm')

                multiplier = 60;

            if(time == 0)
                System.Environment.Exit(0);

            Prstart(time * multiplier);
            

            
            
        }

        static void Prstart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int Time)
        {
           
            int currentTime = 0;

            while (currentTime != Time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
               Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronometragem Finalizada");
            Thread.Sleep(3000);
            Menu();
        }
    }

}
