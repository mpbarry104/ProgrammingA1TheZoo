using System;
using UnityEngine;

public class Octopus : Animal
{
    public bool CanRegenerate { get; set; }

    public Octopus() : base("Axolotl", 15f, 50f, 20f, false, false)
    {
        CanRegenerate = true;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Octopus makes a soft bubbling sound.");
    }

    public void Regenerate()
    {
        Console.WriteLine("Octopus is regenerating its lost leg!");
    }
}