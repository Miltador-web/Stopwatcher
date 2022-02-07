using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            System.Console.WriteLine("S = Segundos => cada segundo");
            System.Console.WriteLine("M = Minutos => cada 60 segundos");
            System.Console.WriteLine("0 = Sair");
            var  res = Console.ReadLine().ToLower();
            if(res == "0"){
                System.Environment.Exit(0);
            }
            System.Console.WriteLine("Digite a quantidade: ");
            System.Console.WriteLine("-----------------------------------------------");
            int resnum = int.Parse(Console.ReadLine());
            switch(res){
                case "s": Start(resnum); break;
                case "m": Start(resnum*60); break;
                default: Menu(); break;
            }
        }
        static void Start(int time){

            Console.Clear();
            
            int currentTime = 0;
            while(currentTime != time){
                Console.Clear();
                currentTime++;
                System.Console.WriteLine(currentTime);
                Thread.Sleep(1000);

            }
            Console.Clear();
            System.Console.WriteLine("StopWatch finalizado...");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
