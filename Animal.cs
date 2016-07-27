using System;

namespace Zoolandia
{
    public abstract class Animal
    {
        public Animal (string name)
        {
            this.Name = name;
        }
        public virtual string Eat(int numberOfFoods) 
        {
            return "YUM!";
        }

        public string Welcome (string name)
        {
            this.Name = name;
            return Welcome();
        }

        public string Welcome()
        {
            return "Welcome, " + this.Name;
        }
        
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
    }
}