using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public class Fox : Animal
    {
        protected string _tail = "fluffy";


        public Fox(string tail) : base()
        {
            _tail = tail;
        }

        public Fox(string name, string color, string environment, int legAmount,
            string nature, string food, string tail) : base
            (name, color, environment, legAmount, nature, food)
        {
            _tail = tail;
        }
        public override void PrintInfo()
        {
            Console.Write("The fox ");
            base.PrintInfo();
            Console.WriteLine($"The fox's tail is {_tail}");
            Console.WriteLine();
        }
        public override void MakeSound()
        {
            Console.WriteLine("What does the fox say? \"Ring-ding-ding-ding-" +
                "dingeringeding! Gering - ding - ding - ding - dingeringeding!" +
                " Gering - ding - ding - ding - dingeringeding!\"");
        }

        public void Sneak()
        {
            Console.WriteLine("The fox sneaks around the hen house.");
        }
    }
}
