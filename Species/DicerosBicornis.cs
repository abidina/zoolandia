namespace Zoolandia.Species
{
    public class DicerosBicornis : Animal
    {
        public DicerosBicornis(string name) : base(name, 2)
        {

        }
        public string Snort()
        {
            return "*snort*";
        }
        
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(4);
            return animalEat + " I don't even know what kind of food I eat!";
        }
    }
}