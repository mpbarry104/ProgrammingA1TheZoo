using System;
using UnityEngine;

public class Octopus : Animal
{
    public bool CanRegenerate { get; set; }

    public Octopus() : base("Octopus", 3f, 30f, 100f, false, false)
    {
        CanRegenerate = true;
    }

    public override void MakeSound()
    {
        Debug.Log("Octopus makes a soft bubbling sound.");
    }

    public void Regenerate()
    {
       Debug.Log("Octopus is regenerating its lost leg!");
    }
}