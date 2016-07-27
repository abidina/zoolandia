namespace Zoolandia.Species
{
    public class CheloniaMydas : Animal
    {
        public CheloniaMydas(string name) : base(name)
        {

        }
        public string Swim()
        {
            return "*whoosh*";
        }
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(2);
            return animalEat + " I love eating strawberries.";
        }
    }
}