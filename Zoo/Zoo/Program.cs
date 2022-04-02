using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Hello Zoo!");
            Console.ForegroundColor = ConsoleColor.Red;
            Lion lion = new Lion("Roar");
            Console.Write("\nLion say ");
            lion.Eat();
            lion.Sound();
            Console.WriteLine(lion.CanSwim());            
            //
            Console.ForegroundColor = ConsoleColor.Green;
            Penguin penguin = new Penguin(false, "Bleat", "Fish", "Orange");
            Console.Write("\nPenguin say ");
            penguin.Fly(penguin.canFly);
            Console.ForegroundColor = ConsoleColor.Blue;
            //
            Crocodile crocodile = new Crocodile("Growls", "Meat");
            Console.Write("\nCrocodile's voice ");
            crocodile.Sound();
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
