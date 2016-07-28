namespace Zoolandia.Species
{
    public class AilurusFulgens : Animal
    {
        public AilurusFulgens(string name, int color) : base(name, 9)
        {
            this.color = color;
        }
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(2);
            return animalEat + "Nom nom nom";
        }
        
    }
}
