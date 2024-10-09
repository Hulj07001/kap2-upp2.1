using System;
namespace kap2upp2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hej! Vilken är din favorit bok? ");
            string favbok=Console.ReadLine();
            Console.WriteLine("Din favorit bok är alltså " + favbok + "?");
        }
    }
}