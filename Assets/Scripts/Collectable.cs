using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    //player walks into collectable
    //add collectable to player
    //delete collectable from screen

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        Player player = collision.GetComponent<Player>();

        if(player)
        {
            //player.numCarrotSeeds++;
            Destroy(this.gameObject);
        }
    }
}
