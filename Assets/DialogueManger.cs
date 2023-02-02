using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManger : MonoBehaviour
{
    public Image actorImage;
    public Text actorName;
    public Text messageText;
    public RectTransform backgroundBox;

    Message[] = currentMessages;
    Actor[] = currentActors;
    int activeMesssage = 0;

    public void OpenDialogue(Message[] messages, Actor[] actors) {
        currentMessages = messages;
        currentActors = actors;
        activeMesssage = 0;

        Debug.Log("Started cinversation! Load Message" + messages.Length);
    }
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
