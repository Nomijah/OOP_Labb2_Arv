using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public class Mouse : Animal
    {
        protected string _taste = "NoData";
        protected bool _alive = true;

        public string taste { get => _taste; }
        public bool alive { get => _alive; set => _alive = value; }

        public Mouse() : base()
        {

        }

        public Mouse(string name, string color, string environment, 
            int legAmount, string nature, string food, string taste) : base
            (name, color, environment, legAmount, nature, food)
        {
            _taste = taste;
            _alive = true;
        }

        public override void PrintInfo()
        {
            Console.Write("The mouse ");
            base.PrintInfo();
            Console.WriteLine($"This mouse is {_taste}.");
            Console.WriteLine();
        }

        public override void MakeSound()
        {
            Console.WriteLine("The mouse squeaks.");
        }

        public void CheckLifeSigns()
        {
            if (_alive)
            {
                Console.WriteLine($"{_name} is still alive.");
            }
            else
            {
                Console.WriteLine($"{_name} has been eaten by a predator.");
            }
        }
    }
}
