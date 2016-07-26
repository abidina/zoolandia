﻿using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AilurusFulgens RedPanda = new AilurusFulgens("Red Panda");
            RedPanda.Name = "Red Panda";
            string response = RedPanda.Eat();
            Console.WriteLine(RedPanda.Name + " says " + response);

            DicerosBicornis BlackRhino = new DicerosBicornis("Black Rhino");
            BlackRhino.Name = "Black Rhino";
            Console.WriteLine(BlackRhino.Name + " says " + BlackRhino.Snort());
            Console.WriteLine(BlackRhino.Welcome());

            CheloniaMydas GreenTurtle = new CheloniaMydas("Green Turtle");
            GreenTurtle.Name = "Green Turtle";
            Console.WriteLine("The " + GreenTurtle.Name + " likes to swim. " + GreenTurtle.Swim());

            PanPaniscus Bonobo = new PanPaniscus("Bonobo");
            Bonobo.Name = "Bonobo";
            Console.WriteLine("Stay away from the " + Bonobo.Name + ". He's dangerous! " + Bonobo.Growl());
        }
    }
}
