using System;
using UnityEngine;

public abstract class Animal : MonoBehaviour
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