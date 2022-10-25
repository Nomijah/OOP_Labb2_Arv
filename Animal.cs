using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public abstract class Animal
    {
        protected string _Name = "NoName";
        protected string _Color = "NoColor";
        protected string _Environment = "NoEnvironment";
        protected int _LegAmount = 4;
        protected string _Nature = "NoNature";
        protected string _Food = "NoFood";

        public Animal()
        {

        }
        public Animal(string name, string color, string environment,
            string nature, string food)
        {
            _Name = name;
            _Color = color;
            _Environment = environment;
            _Nature = nature;
            _Food = food;
        }

        public virtual void PrintInfo()
        { 
            Console.WriteLine($"{_Name} is {_Color} and lives in " +
                $"{_Environment}.\nIt has {_LegAmount} legs and eats {_Food}." +
                $"\n{_Name} is {_Nature} in it's nature.");
        }
        public virtual void Eat()
        {
            Console.WriteLine($"{_Name} eats {_Food}.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"The animal sleeps in {_Environment}");
        }

        public virtual void Walk()
        {
            if (_LegAmount < 2)
                Console.WriteLine("The animal can't walk.");
            else
                Console.WriteLine($"The animal takes a stroll on its " +
                    $"{_LegAmount} legs.");
        }

        public void Pet()
        {
            if (_Nature == "Calm")
                Console.WriteLine("You can pet this animal.");
            else if (_Nature == "Aggressive")
                Console.WriteLine("Keep your distance!");
            else
                Console.WriteLine("Pet at your own risk.");
        }
    }
}
