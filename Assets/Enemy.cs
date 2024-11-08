using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health): base(name, health)
    {
    }
public void attack (Character target , int damge ){
    int heal = target.Health - damge ;
    if (heal<0)
    target.Health = 0 ;
    else 
    target.Health =heal;
}

}
