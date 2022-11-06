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
            Console.WriteLine();
        }
        public override void MakeSound()
        {
            Console.WriteLine("The horse neighs!");
        }

        public void Race()
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, 7);
            switch (chance)
            {
                case 0:
                    Console.WriteLine($"{_name} wins the race!");
                    break;
                case 1:
                    Console.WriteLine($"{_name} came in second place, " +
                        $"so close!");
                    break;
                case 6:
                    Console.WriteLine($"{_name} came in last place, too bad!");
                    break;
                default:
                    Console.WriteLine($"{_name} didn't win.");
                    break;
            }
        }
    }
}