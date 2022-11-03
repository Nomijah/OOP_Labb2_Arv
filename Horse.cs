using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public class Horse : Animal
    {
        private string _blood = "NoData";

        public Horse(string blood) : base()
        {
            _blood = blood;
        }

        public Horse(string name, string color, string environment, int legAmount,
            string nature, string food, string blood) : base
            (name, color, environment, legAmount, nature, food)
        {
            _blood = blood;
        }

        public override void PrintInfo()
        {
            Console.Write("The horse ");
            base.PrintInfo();
            Console.WriteLine($"This horse is a {_blood}");
        }
        public override void MakeSound()
        {
            Console.WriteLine("The horse neighs!");
        }

    }
}