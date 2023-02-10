using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class AnswersScript : MonoBehaviour
{
    public bool isRight = false;
    public QuizManager quizManager;


    void Answers()
    {
        if (isRight)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            quizManager.correct();
        }
    }
}