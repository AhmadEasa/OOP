using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player = new Player("Ahmad", 90);
        Enemy enemy = new Enemy("amin", 50); //This isn’t accurate; you’re not an enemy—just an example :) enjoy
        Debug.Log("Player Name: " + player.Name + ", Health: " + player.Health);
        Debug.Log("Enemy Name: " + enemy.Name + ", Health: " + enemy.Health);

    player.afterProcessing(15);
    Debug.Log("After regaining some of its strength, Player Health: " + player.Health);

    enemy.attack(player, 30);
    Debug.Log("After being attacked, Player Health: " + player.Health);

    }
    

}
