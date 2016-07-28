using System;

namespace Zoolandia
{
    public abstract class Animal
    {
        public Animal (string name, int c)
        {
            this.Name = name;
            this.color = color;
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
        private int c;
        public int color 
        {
            get 
            {
                return c;
            }
            set 
            {
                c = value;
            }
        }
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