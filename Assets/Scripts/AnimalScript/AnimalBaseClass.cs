public class Animal
{
    public float Lifespan;
    public float Hunger;
    public float Intelligence;

    public bool isHerbivore;
    public bool isBipedal;
    public bool isMurderous;
    public Animal(float lifespan, float hunger, float intelligence, bool herbivore, bool bipedal, bool murderous)
    {
        Lifespan = lifespan;
        Hunger = hunger;
        Intelligence = intelligence;
        isHerbivore = herbivore;
        isBipedal = bipedal;
        isMurderous = murderous;
    }
}
public class Axolotl : Animal
{
    public Axolotl() : base(15f, 30f, 20f, false, false, false) { }
}
