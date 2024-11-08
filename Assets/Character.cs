using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Character
{
    private string name;
    private int health;


    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Health
    {
        get { return health; }
        set
        {
            if (value < 0)
                health = 0;
            else if (value > 100)
                health = 100;
            else
                health = value;


        }
    }
    public Character(string name, int health)
    {
        this.name = name;
        if (health < 0)
            this.health = 0;
        else if (health > 100)
            this.health = 100;
        else
            this.health = health;

    }
}