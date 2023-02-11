using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnswersScript : MonoBehaviour
{
    public bool isRight = false;
    public QuizManager quizManager;

    public void Answers()
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