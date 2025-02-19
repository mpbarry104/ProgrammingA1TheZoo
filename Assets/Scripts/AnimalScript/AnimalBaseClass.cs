using System;

public abstract class Animal
{
    public string Name { get; set; }
    public float Lifespan { get; set; }
    public float Hunger { get; set; }
    public float Intelligence { get; set; }

    public bool IsHerbivore { get; set; }
    public bool IsBipedal { get; set; }

    // Constructor
    public Animal(string name, float lifespan, float hunger, float intelligence, bool herbivore, bool bipedal)
    {
        Name = name;
        Lifespan = lifespan;
        Hunger = hunger;
        Intelligence = intelligence;
        IsHerbivore = herbivore;
        IsBipedal = bipedal;
    }
    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
        Hunger -= 10;
    }

    public abstract void MakeSound();
}
public class Axolotl : Animal
{
    public bool CanRegenerate { get; set; }

    public Axolotl() : base("Axolotl", 15f, 50f, 20f, false, false)
    {
        CanRegenerate = true;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Axolotl makes a soft chirping sound.");
    }

    public void Regenerate()
    {
        Console.WriteLine("Axolotl is regenerating its lost limb!");
    }
}
public class Raccoon : Animal
{
    public bool IsNocturnal { get; set; }

    public Raccoon() : base("Raccoon", 5f, 70f, 50f, false, true)
    {
        IsNocturnal = true;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Raccoon chatters and growls.");
    }

    public void Scavenge()
    {
        Console.WriteLine("Raccoon is rummaging through trash!");
    }
}
public class Gorilla : Animal
{
    public bool UsesTools { get; set; }

    public Gorilla() : base("Gorilla", 35f, 40f, 90f, true, true)
    {
        UsesTools = true;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Gorilla beats its chest and grunts.");
    }
    public void ClimbTrees()
    {
        Console.WriteLine("Gorilla is climbing a tree!");
    }
}
public class Penguin : Animal
{
    public bool CanSwim { get; set; }

    public Penguin() : base("Penguin", 20f, 55f, 40f, false, true)
    {
        CanSwim = true;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Penguin makes a honking noise.");
    }

    public void Swim()
    {
        Console.WriteLine("Penguin is swimming in cold waters!");
    }
}