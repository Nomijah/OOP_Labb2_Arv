using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public class Bird : Animal
    {
        bool _CanFly;
        public Bird(bool canFly) : base()
        {
            _CanFly = canFly;
            _LegAmount = 2;
        }
        public Bird(string name, string color, string environment,
            string nature, string food, bool canFly) : base (name, color, 
                environment, nature, food)
        {
            _CanFly = canFly;
            _LegAmount = 2;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            if (_CanFly)
                Console.WriteLine("It can fly.");
            else
                Console.WriteLine("It can't fly.");
        }
        public void Fly()
        {
            if (_CanFly)
                Console.WriteLine($"{_Name} flies across the sky!");
            else
                Console.WriteLine($"{_Name} can't fly.");
        }
    }
}
