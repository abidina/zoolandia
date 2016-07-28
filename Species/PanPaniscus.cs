//bonobo
namespace Zoolandia.Species
{
    public class PanPaniscus : Animal
    {
        public PanPaniscus(string name) : base(name, 4)
        {

        }
        public string Growl()
        {
            return "GrrrrrrAAA!";
        }
        
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(1);
            return animalEat + " If you're not careful, he'll eat YOU.";
        }
    }
}