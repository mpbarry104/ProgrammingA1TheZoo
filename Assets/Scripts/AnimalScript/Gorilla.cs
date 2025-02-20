using System;
using UnityEngine;

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