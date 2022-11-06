using System;

namespace OOP_Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test animals
            Horse horse1 = new Horse("Lukas", "black", "the stable",3, "calm", "Snickers", "full blood");
            Fox fox1 = new Fox("Elsa", "red", "the woods", 4, "aggressive", "rabbits", "fluffy");
            Hen hen1 = new Hen("Agda", "brown", "the henhouse", 1, "nervous", "worms", false, 4);
            Eagle eagle1 = new Eagle("Bertil", "brown and white", "the mountains", 2, "aggressive", "critters", true, 8);
            Mouse mouse1 = new Mouse("Gus", "brown", "the walls of a house", 4, "scared", "cheese", "juicy");
            Mouse mouse2 = new Mouse("Jack", "grey", "the forest", 4, "wild", "nuts", "skinny");
            Mouse mouse3 = new Mouse("Francis", "white", "a cage", 4, "tame", "goose liver", "weird");

            // Tests make sound method
            horse1.MakeSound();
            fox1.MakeSound();
            hen1.MakeSound();
            eagle1.MakeSound();
            mouse1.MakeSound();
            Console.WriteLine();

            // Tests pet method
            fox1.Pet();
            mouse3.Pet();
            hen1.Pet();
            Console.WriteLine();

            // Tests walk method
            horse1.Walk();
            hen1.Walk();
            Console.WriteLine();

            // Tests sleep method
            fox1.Sleep();
            eagle1.Sleep();
            mouse3.Sleep();
            Console.WriteLine();
            
            // Tests eat method
            horse1.Eat();
            eagle1.Eat();
            mouse2.Eat();
            Console.WriteLine();

            //Tests horse race
            horse1.Race();
            Console.WriteLine();
            horse1.Race();
            Console.WriteLine();
            horse1.Race();
            Console.WriteLine();

            // Tests fox sneak
            fox1.Sneak();
            Console.WriteLine();

            // Tests fly method
            hen1.Fly();
            eagle1.Fly();
            Console.WriteLine();

            // Tests hen laying egg
            hen1.PrintInfo();
            hen1.LayEgg();
            hen1.PrintInfo();
            Console.WriteLine();

            // Tests eagle eating mouse and checklifesigns method
            mouse1.PrintInfo();
            mouse1.CheckLifeSigns();
            eagle1.EatMouse(mouse1);
            mouse1.CheckLifeSigns();
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
