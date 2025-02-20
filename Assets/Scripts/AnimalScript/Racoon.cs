using System;
using UnityEngine;

public class Raccoon : Animal
{
    public bool IsNocturnal { get; set; }

    public Raccoon() : base("Raccoon", 5f, 70f, 50f, false, true)
    {
        IsNocturnal = true;
    }

    public override void MakeSound()
    {
        Debug.Log("Raccoon chatters and growls.");
    }

    public void Scavenge()
    {
       Debug.Log("Raccoon is rummaging through trash!");
    }
}