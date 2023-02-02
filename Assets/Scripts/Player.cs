using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public float speeds = 3.0f;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    public int numCarrotSeeds = 0;

    void Update()
    {
        // This is the start of basic movement
        horizontal = Input.GetAxis("Horizontal"); //this is a update func float # named horizontal Stores input "Horizontal" provides
        vertical = Input.GetAxis("Vertical");
        // This is the end of basic movement

        // Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        // transform.positon += input.normalized * speed * Time.deltaTime;

        // if(input != Vector3.zero){
        //     anim.SetBool("isRunning", true);
        // }else{
        //     anim.SetBool("isRunning", false);
        // }
    }
        // This is the start of basic movement
    void FixedUpdate() 
    {
        Vector2 position = GetComponent<Rigidbody2D>().position;
        position.x = position.x + (speeds * horizontal) * Time.deltaTime;
        position.y = position.y + (speeds * vertical) * Time.deltaTime;

        GetComponent<Rigidbody2D>().MovePosition(position);
    }
}
