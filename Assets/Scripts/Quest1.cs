using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Quest1 : MonoBehaviour
{
    public Image questItem;
    public Color completedColor;
    public Color activeColor;
    public Color currentColor;

    public QuestArrow arrow;
    public Quest[] allQuests;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
     if(collision.tag == "Player") {
        FinishQuest();
        Destroy(gameObject);
     }   
    }
    void FinishQuest(){
        questItem.GetComponent<Button>().interactable = false;
        currentColor = completedColor;
        questItem.color = completedColor;
    }
    // Start is called before the first frame update
    void Start()
    {
        allQuests = FindObjectOfType<Quest>();
    }

    public void OnQuestClick(){
        arrow.gameObject.SetActive(true);
        foreach(Quest in allQuests){
            quest.questItem.color = quest.currentColor;
        }
        questItem.color = activeColor;
    }
    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
