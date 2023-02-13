using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
//{
//    public float speed;
//    public Animator animator;

//    private Vector3 direction;

//    void Start()
//    {

//    }

//    void Update()
//    {
//        float horizontal = Input.GetAxisRaw("Horizontal");
//        float vertical = Input.GetAxisRaw("Vertical");

//        direction = new Vector3(horizontal, vertical);

//        AnimateMovement(direction);

//        // if (DialogueManager.isActive == true)
//        //     return;
//        // }


//    }

//    private void FixedUpdate()
//    {
//        this.transform.position += direction * speed * Time.deltaTime;

//    }

//    void AnimateMovement(Vector3 direction)
//    {
//        if (animator != null)
//        {
//            if (direction.magnitude > 0)
//            {
//                animator.SetBool("isMoving", true);

//                animator.SetFloat("horizontal", direction.x);
//                animator.SetFloat("vertical", direction.y);
//            }
//            else
//            {
//                animator.SetBool("isMoving", false);
//            }
//        }
//    }
//}
{
    public int maxHealth = 5;
    int currentHealth;

    public float speed = 1.0f;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        //    QualitySettings.vSyncCount = 0;
        //    Application.targetFrameRate = 8;

        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal"); //this is a update func float # named horizontal Stores input "Horizontal" provides
        vertical = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        Vector2 position = GetComponent<Rigidbody2D>().position;
        position.x = position.x + (speed * horizontal) * Time.deltaTime;
        position.y = position.y + (speed * vertical) * Time.deltaTime;

        GetComponent<Rigidbody2D>().MovePosition(position);
    }
}