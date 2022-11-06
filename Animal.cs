using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb2_Arv
{
    public abstract class Animal
    {
        protected string _name = "NoName";
        protected string _color = "NoColor";
        protected string _environment = "NoEnvironment";
        protected int _legAmount = 0;
        protected string _nature = "NoNature";
        protected string _food = "NoFood";

        //Accessor for name
        public string name { get => _name; }

        public Animal()
        {

        }
        public Animal(string name, string color, string environment,
            int legAmount, string nature, string food)
        {
            _name = name;
            _color = color;
            _environment = environment;
            _legAmount = legAmount;
            _nature = nature;
            _food = food;
        }

        public virtual void PrintInfo()
        { 
            Console.Write($"{_name} is {_color} and lives in " +
                $"{_environment}.\nIt has {_legAmount} legs and eats {_food}." +
                $"\n{_name} is {_nature} in it's nature. \n");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("What does this animal sound like?");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{_name} eats {_food}.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{_name} sleeps in {_environment}.");
        }

        public void Walk()
        {
            if (_legAmount < 2)
            {
                Console.WriteLine("The animal can't walk.");
            }
            else
            {
                Console.WriteLine($"The animal takes a stroll on its " +
                    $"{_legAmount} legs.");
            }
        }

        public void Pet()
        {
            if (_nature.ToLower() == "calm" || _nature.ToLower() == "tame")
            {
                Console.WriteLine($"You can pet {_name}.");
            }
            else if (_nature.ToLower() == "aggressive")
            {
                Console.WriteLine($"Keep your distance from {_name}!");
            }
            else
            {
                Console.WriteLine($"Pet {_name} at your own risk.");
            }
        }
    }
}
