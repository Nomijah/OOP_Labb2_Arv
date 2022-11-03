using System;

namespace OOP_Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird Hen = new Bird(false);
            Hen.PrintInfo();
            Horse Arab = new Horse("Kent", "black", "the stable",3, "calm", "Snickers", "full blood");
            Arab.PrintInfo();
            Arab.Walk();
            Fox theFox = new Fox("Häst", "red", "the woods", 4, "aggressive", "rabbits", "fluffy");
            theFox.PrintInfo();
            theFox.MakeSound();

            
        }
    }
}
