using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public class Bird : Animal
    {
        protected bool _canFly = true;
        public Bird(bool canFly) : base()
        {
            _canFly = canFly;
        }
        public Bird(string name, string color, string environment, int legAmount,
            string nature, string food, bool canFly) : base 
            (name, color, environment, legAmount, nature, food)
        {
            _canFly = canFly;
        }
        public override void PrintInfo()
        {
            Console.Write("The bird ");
            base.PrintInfo();
            if (_canFly)
            {
                Console.WriteLine("It can fly.");
            }
            else
            {
                Console.WriteLine("It can't fly.");
            }
            Console.WriteLine();
        }

        public override void MakeSound()
        {
            Console.WriteLine("The bird chirps beautifully!");
        }
        public virtual void Fly()
        {
            if (_canFly)
                Console.WriteLine($"{_name} flies across the sky!");
            else
                Console.WriteLine($"{_name} can't fly.");
        }
    }
}
