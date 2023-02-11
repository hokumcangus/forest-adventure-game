using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public TMP_Text QuestionTxt;
    public TMP_Text ScoreTxt;
    public int score;
    int totalQuestions = 0;

    public GameObject QuizPanel;
    public GameObject GOPanel;

    void Start()
    {
        totalQuestions = QnA.Count;
        GOPanel.SetActive(false);
        generateQuestion();
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        // When wrong remove the question
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void quit()
    {
        QuizPanel.SetActive(false);
        GOPanel.SetActive(false);
    }
    public void retry()
    {
        // Getting the index of the scene and loading it
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Close the QuizPanel and Open the GameOver panel
    public void GameOver()
    {
        QuizPanel.SetActive(false);
        GOPanel.SetActive(true);
        ScoreTxt.text = score + "/" + totalQuestions;
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswersScript>().isRight = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i)
            {
                options[i].GetComponent<AnswersScript>().isRight = true;
            }
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions!");
            GameOver();
        }
    }
}
