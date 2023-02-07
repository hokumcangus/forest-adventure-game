using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] 
public class Dialogue
{
    //host information for a single dialogue
    public string name;

    [TextArea(3,5)]
    public string[] sentences;


    // public string name;
    // public int id;
    // public int unhelpfulIndex;
    // [TextArea(3, 5)] [SerializeField] public string[] greetings;
    // [TextArea(3,5)] [SerializeField] public string askForAction;
    // [TextArea(3, 5)] [SerializeField] public string[] playGame;
    // [TextArea(3,5)] [SerializeField] public string goodbye;
    

    // [TextArea(3,5)] [SerializeField] string[] reactions;

}
