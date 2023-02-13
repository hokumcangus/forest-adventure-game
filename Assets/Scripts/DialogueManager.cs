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

    private bool dialoguePanelBool =  false;

    public GameObject contButton;
    public float wordSpeed;

    void Start()
    {
        if (dialoguePanel)
        {
            sentences = new Queue<string>();
        }
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
