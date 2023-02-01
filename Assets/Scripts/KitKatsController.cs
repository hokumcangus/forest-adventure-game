using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitKatsController : MonoBehaviour
{   
    // This is the start of basic movement
    public int maxHealth = 5;
    int currentHealth;

    public float speeds = 3.0f;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    // This is the end of basic movement

    // This is the start of Quest behavior
    // public float speed;
    public Animator anim;
    // This is the end of the Quest behavior

    // Start is called before the first frame update
    void Start()
    {
        // rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;

    // This is the start of Quest behavior
        anim = GetComponent<Animator>();
    // This is the end of the Quest behavior
    }

    // Update is called once per frame
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
    void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
