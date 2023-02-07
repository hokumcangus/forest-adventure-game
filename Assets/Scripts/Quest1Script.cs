using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Quest1Script : MonoBehaviour
{
    public Image questItem;
    public Color completedColor;
    public Color activeColor;

    public QuestArrow arrow;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
     if(collision.tag == "Player") {
        FinishQuest();
        Destroy(gameObject);
     }   
    }
    void FinishQuest(){
        questItem.color = completedColor;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
