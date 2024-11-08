using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Player(string name, int health): base(name, health)
    {
    }


    public void afterProcessing(int amount)
    {
        int heal = Health + amount;

        if (heal > 100)
            Health = 100;
        else
            Health = heal;

    }
}
