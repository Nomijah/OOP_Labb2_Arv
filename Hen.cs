﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public class Hen : Bird
    {
        protected int _eggsLaid = 0;

        public Hen(int eggsLaid, bool canFly) : base(canFly)
        {
            _eggsLaid = eggsLaid;
        }

        public Hen(string name, string color, string environment, int legAmount,
            string nature, string food, bool canFly, int eggsLaid) : base
            (name, color, environment, legAmount, nature, food, canFly)
        {
            _eggsLaid = eggsLaid;
        }


        public override void PrintInfo()
        {
            Console.Write("The hen ");
            base.PrintInfo();
            if (_canFly)
                Console.WriteLine("It can fly.");
            else
                Console.WriteLine("It can't fly.");
        }
        public override void Fly()
        {
            if (_canFly)
            {
                Console.WriteLine("Wow! It can fly, I've never heard of a " +
                    "hen that can fly!");
            }
            else
            {
                Console.WriteLine("Did you really think that the hen could " +
                    "fly?");
            }
        }


    }
}
