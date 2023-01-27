using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
//     public float speed;
//     private Animator anim;

//     // This part of code is for dialogue with NPC
//     public GameObject dialoguePanel;
//     public Text dialoguePanel;
//     public string[] dialogue;
//     private int index;

//     public float wordSpeed;
//     public bool playerIsClose;
    
//     void Start() 
//     {
//         anim = GetComponent<Animator>();
//     }

//     void Update() {
//         Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
//         transform.position += input.normalized * speed * Time.deltaTime;

//         if(input != Vector3.zero){
//             anim.SetBool("isRunning", true);
//         else{
//             anim.SetBool("isRunning", false);
//         }
//         if(Input.GetKeyDown(KeyCode.E)&& playerIsClose)
//         {
//             zeroText();
//         }
//         else{
//             dialoguePanel.SetActive(true);
//         }
//     }
//     private void OnTriggerEnter2D(Collider2D other)
//     {
//         if(other.CompareTag("Player"))
//         {
//             playerIsClose = true;
//         }
//     }
//     private void OnTriggerExit2D(Collider2D other)
//     {
//         if(other.CompareTag("Player"))
//         {
//             playerIsClose = false;
//             zeroText();
//         }
//     }
// }
//     private void zeroText()
//     {
//         dialogueText.text = "";
//         index: 0;
//         dialoguePanel.SetActive(false);
//     }
//     IEnumerator Typing()
// }
    
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal"); //this is a update func float # named horizontal Stores input "Horizontal" provides
        vertical = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
        Vector2 position = GetComponent<Rigidbody2D>().position;
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        transform.position = position;
   }
        position.x = position.x + (speed * horizontal) * Time.deltaTime;
        position.y = position.y + (speed * vertical) * Time.deltaTime;

        GetComponent<Rigidbody2D>().MovePosition(position);
    
    void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }