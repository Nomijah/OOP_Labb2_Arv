using System;

namespace OOP_Labb2_Arv
{
    public class Eagle : Bird
    {
        protected int _miceAmount = 0;
        public Mouse mouse;

        public Eagle(int miceAmount, bool canFly) : base(canFly)
        {
            _miceAmount = miceAmount;
        }

        public Eagle(string name, string color, string environment, int legAmount,
            string nature, string food, bool canFly, int miceAmount) : base
            (name, color, environment, legAmount, nature, food, canFly)
        {
            _miceAmount = miceAmount;
        }

        public override void PrintInfo()
        {
            Console.Write("The eagle ");
            base.PrintInfo();
            Console.WriteLine();
        }
        public override void MakeSound()
        {
            Console.WriteLine("The eagle delivers a high pitched screech " +
                "from above.");
        }

        public override void Eat()
        {
            {
            Console.WriteLine($"The eagle eats {_food} and it has eaten " +
                $"{_miceAmount} mice in it's lifetime.");
            }
        }

        public void EatMouse(Mouse mouse)
        {
            if (mouse.alive == true)
            {
                _miceAmount++;
            Console.WriteLine($"{_name} eats {mouse.name} and it tastes " +
                $"{mouse.taste}.");
            mouse.alive = false;
            }
            else
            {
                Console.WriteLine("The eagle prefers to hunt its prey.");
            }
        }

        public override void Fly()
        {
            if (_canFly)
            {
                Console.WriteLine("The eagle soars across the sky!");
            }
            else
            {
                Console.WriteLine("'Tis a sad day cuz this eagle can not fly.");
            }
        }
    }
}
