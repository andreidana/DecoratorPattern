using System;

namespace DecoratorExample
{
    internal class Program
    {
        public static void Main()
        {
            ISport footballer = new Footballer();
            Console.WriteLine($"A footballer runs with {footballer.Run()} km/h");

            ISport keeper = new Keeper();
            Console.WriteLine($"A keeper runs with {keeper.Run()} km/h");

            ISport fieldPlayer = new FieldPlayer();
            Console.WriteLine($"A fieldPlayer runs with {fieldPlayer.Run()} km/h");
        }
    }
}
