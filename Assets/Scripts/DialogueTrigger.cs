using UnityEngine;


public class DialogueTrigger : MonoBehaviour{
    
    public Dialogue dialogue;

    public void TiggerDialogue () 
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}                  