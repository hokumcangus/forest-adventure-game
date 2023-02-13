using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Quest : MonoBehaviour
{
    public Image questItem;
    public Color completedColor;
    public Color activeColor;
    public Color currentColor;


    public QuestArrow arrow;
    public Quest[] allQuests;

    void Start()
    {
        allQuests = FindObjectsOfType<Quest>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FinishQuest();
            Destroy(gameObject);
        }
    }

    void FinishQuest()
    {
        questItem.GetComponent<Button>().interactable = false;
        currentColor = completedColor;
        questItem.color = completedColor;
    }

    public void OnQuestClick()
    {
        //arrow.gameObject.SetActive(true);
        arrow.target = this.transform;
        arrow.gameObject.SetActive(false);
        foreach (Quest quest in allQuests)
        {
            quest.questItem.color = quest.currentColor;
        }
        questItem.color = activeColor;
    }
}