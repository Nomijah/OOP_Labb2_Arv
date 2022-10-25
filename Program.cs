using System;

namespace OOP_Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird Hen = new Bird("Hen", "brown", "farm", "calm", "fodder", false);
            Hen.PrintInfo();
        }
    }
}
