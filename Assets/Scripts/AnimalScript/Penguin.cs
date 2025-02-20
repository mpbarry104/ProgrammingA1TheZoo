using System;
using UnityEngine;

public class Penguin : Animal
{
    public bool CanSwim { get; set; }

    public Penguin() : base("Penguin", 20f, 55f, 40f, false, true)
    {
        CanSwim = true;
    }

    public override void MakeSound()
    {
        Debug.Log("Penguin makes a honking noise.");
    }

    public void Swim()
    {
        Debug.Log("Penguin is swimming in cold waters!");
    }
}