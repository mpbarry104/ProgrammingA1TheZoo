using System;
using UnityEngine;

public class Penguin : Animal, IInteractable
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
    
    public void Interact()
    {
        Debug.Log("You pet the Penguin and it watches surfs up in 4k.");
        MakeSound();
    }
}