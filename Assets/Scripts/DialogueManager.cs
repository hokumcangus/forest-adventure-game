using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class DialogueManager : MonoBehaviour
{

    public TMP_Text nameText;
    public TMP_Text dialogueText;

    //public Animator animator;

    private Queue<string> sentences;

    private bool playerInRange = false;

    public GameObject dialoguePanel;

    public GameObject contButton;
    public float wordSpeed;

    void Start()
    {

        sentences = new Queue<string>();


    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Stating conversation with " + dialogue.name);

        //animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

        Debug.Log(sentence);
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void Update() // This function was recently added 
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {

            if (dialoguePanel.activeInHierarchy)
            {
                sentences.Clear();
            }
            else
            {
                dialoguePanel.SetActive(true);
                DisplayNextSentence();
                //StartCoroutine(TypeSentence(sentences));
            }
            //if (dialogueText.text == dialogue[index])
            //{
            //    contButton.SetActive(true);
            //}
        }
    }

    void EndDialogue()
    {
        
        Debug.Log("End of conversation");
        //animator.SetBool("IsOpen", false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            EndDialogue();
        }
    }
}
// public class DialogueManager : MonoBehaviour
// {
//     public Image actorImage;
//     public Text actorName;
//     public Text messageText;
//     public RectTransform backgroundBox;

//     Message[] currentMessages;
//     Actor[] currentActors;
//     int activeMesssage = 0;
//     public static bool isActive = false;

//     public void OpenDialogue(Message[] messages, Actor[] actors) {
//         currentMessages = messages;
//         currentActors = actors;
//         activeMesssage = 0;
//         isActive = true;

//         Debug.Log("Started conversation! Load Message" + messages.Length);
//         // DisplayMessage();
//         // backgroundBox.LeanScale(Vector3.one, 0.5f);
//     }

//     public void DisplayMessage(){
//         Message messageToDisplay = currentMessages[activeMesssage];
//         messageText.text = messageToDisplay.message;

//         Actor actorToDisplay = currentActors[messageToDisplay.actorId];
//         actorName.text = actorToDisplay.name;
//         actorImage.sprite = actorToDisplay.sprite;
//     }

//     public void NextMessage(){
//         activeMesssage++;
//         if (activeMesssage < currentMessages.Length) {
//             // DisplayMessage();
//         }
//         else{
//             Debug.Log("Conversation Ended");
//             isActive = false;
//         }
//     }
//     private void Start() {

//     }

//     private void Update() {
//         if (Input.GetKeyDown(KeyCode.Space) && isActive == true) {
//             NextMessage();
//         }
//     }
// }
// public class DialogueManager : MonoBehaviour
// {
//     public GameObject menu;
//     public GameObject dialoguePanel;
//     public GameObject dialogueOptions;
//     public List<GameObject> characterSprites;
//     public int currentCharacter;
//     public TMP_Text textComponent;

//     public Dialogue dialogue;
//     public bool playerInRange;
//     public bool dialogueStarted;
//     State currentState;
//     public static bool isActive = false;

//     public void OpenDialogue(Message[] messages, Actor[] actors) {
//         // currentMessages = messages;
//         // currentActors = actors;
//         // activeMesssage = 0;
//         isActive = true;

//         Debug.Log("Started conversation! Load Message" + messages.Length);
//     }
//     enum State 
//     {
//         greeting,
//         askForAction,
//         playGame,
//         translate,
//         goodbye,
//         end
//     }

//     void Start()
//     {
//     }

//     void Update()
//     {
//         if(Input.GetKeyDown(KeyCode.X) && isActive == true)
//         {
//             if(dialogueStarted)
//             {
//                 DisplayNextSentence();
//             }
//             else
//             {
//                 StartDialogue();
//                 dialogueStarted = true;
//             }
//         }
//     }

//     public void StartDialogue ()
//     {
//         if(!dialoguePanel.activeInHierarchy)
//         {
//             dialoguePanel.SetActive(true);
//         }

//         menu.SetActive(false);

//         currentCharacter = dialogue.id;
//         characterSprites[currentCharacter].SetActive(true);

//         currentState = State.greeting;

//         DisplayNextSentence();
//     }

//     public void DisplayNextSentence()
//     {
//         switch(currentState)
//         {
//             case State.greeting:
//                 int greetingIndex = Random.Range(0, dialogue.greetings.Length);
//                 textComponent.text = dialogue.greetings[greetingIndex];
//                 currentState = State.askForAction;
//                 break;
//             case State.askForAction:
//                 textComponent.text = dialogue.askForAction;
//                 dialogueOptions.SetActive(true);
//                 break;
//             case State.playGame:
//                 break;
//             case State.translate:
//                 break;
//             case State.goodbye:
//                 textComponent.text = dialogue.goodbye;
//                 currentState = State.end;
//                 break;
//             case State.end:
//                 EndDialogue();
//                 break;
//             default:
//                 Debug.Log("Seeya");
//                 break;

//         }
//     }
//     public void ClickQuit()
//     {
//         currentState = State.goodbye;
//         dialogueOptions.SetActive(false);
//         DisplayNextSentence();
//     }

//     public void EndDialogue()
//     {
//         dialoguePanel.SetActive(false);
//         characterSprites[currentCharacter].SetActive(false);
//         dialogueStarted = false;
//         menu.SetActive(true);

//     }

//     private void OnTriggerEnter2D(Collider2D other) 
//     {
//         if(other.CompareTag("Player"))
//         {
//             playerInRange = true;
//         }
//     }
//     private void OnTriggerExit2D(Collider2D other) 
//     {
//         if(other.CompareTag("Player"))
//         {
//             playerInRange = false;
//             EndDialogue();
//         }
//     }
// }
