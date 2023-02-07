// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class NewQuestDialogue : MonoBehaviour
// {
//     public QuestNew quest;

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.tag == "Player")
//         {
//             QuestManager.Instance.ShowQuestDialogue(quest);
//         }
//     }
// }

// public class QuestManager : MonoBehaviour
// {
//     private static QuestManager instance;
//     public static QuestManager Instance
//     {
//         get
//         {
//             if (instance == null)
//             {
//                 instance = FindObjectOfType<QuestManager>();
//             }
//             return instance;
//         }
//     }

//     public GameObject questDialogueCanvas;

//     public void ShowQuestDialogue(QuestNew quest)
//     {
//         questDialogueCanvas.SetActive(true);
//         QuestDialogueUI questDialogueUI = questDialogueCanvas.GetComponent<QuestDialogueUI>();
//         questDialogueUI.ShowQuestDialogue(quest);
//     }
// }

// [System.Serializable]
// public class QuestNew
// {
//     public string questName;
//     public string questDescription;
//     public string npcName;
//     public string npcDialogue;
// }

// public class QuestDialogueUI : MonoBehaviour
// {
//     public Text npcNameText;
//     public Text npcDialogueText;

//     public void ShowQuestDialogue(QuestNew quest)
//     {
//         npcNameText.text = quest.npcName;
//         npcDialogueText.text = quest.npcDialogue;
//     }
// }
