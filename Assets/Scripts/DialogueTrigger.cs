using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour{
    public Dialogue dialogue;

    public void TiggerDialogue () 
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
//     public Message[] messages;
//     public Actor[] actors;   

//     public void StartDialogue() {
//         // FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
//       }
//  }

// [System.Serializable]
// public class Message {
//     public int actorId;
//     public string message;
// }
   
// [System.Serializable]
// public class Actor {
//     public string name;
//     public Sprite sprite;
// }
                           