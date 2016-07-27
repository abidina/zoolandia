namespace Zoolandia.Species
{
    public class AilurusFulgens : Animal
    {
        public AilurusFulgens(string name) : base(name)
        {

        }
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(2);
            return animalEat + "Nom nom nom";
        }
        
    }
}
