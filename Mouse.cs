using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public class Mouse : Animal
    {
        protected string _taste = "NoData";

        public string taste { get => _taste; }

        public Mouse() : base()
        {

        }

        public Mouse(string name, string color, string environment, 
            int legAmount, string nature, string food, string taste) : base
            (name, color, environment, legAmount, nature, food)
        {
            _taste = taste;
        }

        public override void PrintInfo()
        {
            Console.Write("The mouse ");
            base.PrintInfo();
            Console.WriteLine($"This mouse is {_taste}.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The mouse squeeks.");
        }
    }
}
