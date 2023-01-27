using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnoopDogsController : MonoBehaviour
{
    // public int maxHealth = 5;
    // int currentHealth;

    // public float speed = 3.0f;

    // Rigidbody2D rigidbody2d;
    // float horizontal;
    // float vertical;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     rigidbody2d = GetComponent<Rigidbody2D>();
    //     currentHealth = maxHealth;
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     horizontal = Input.GetAxis("Horizontal"); //this is a update func float # named horizontal Stores input "Horizontal" provides
    //     vertical = Input.GetAxis("Vertical");
    // }
    // void FixedUpdate() 
    // {
    //     Vector2 position = GetComponent<Rigidbody2D>().position;
    //     position.x = position.x + (speed * horizontal) * Time.deltaTime;
    //     position.y = position.y + (speed * vertical) * Time.deltaTime;

    //     GetComponent<Rigidbody2D>().MovePosition(position);
    // }
    // void ChangeHealth(int amount)
    // {
    //     currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
    //     Debug.Log(currentHealth + "/" + maxHealth);
    // }
}
