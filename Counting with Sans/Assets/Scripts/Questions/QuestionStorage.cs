using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionStorage : MonoBehaviour
{
    public GameObject questionBox;
    public GameObject firstAnwserBox;
    public GameObject secondAnwserBox;
    public GameObject thirdAnwserBox;

    public int[] correctAnwsers;

    public string[] questions;
    public string[] firstAnwsers;
    public string[] secondAnwsers;
    public string[] thirdAnwsers;

    public int startingQuestion = 1;
    public int currentQuestion;

    // Start is called before the first frame update
    void Start()
    {
        InstaniatingQuestions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstaniatingQuestions()
    {
        questionBox.GetComponentInChildren<Text>().text = questions[startingQuestion];
        firstAnwserBox.GetComponentInChildren<Text>().text = firstAnwsers[startingQuestion];
        secondAnwserBox.GetComponentInChildren<Text>().text = secondAnwsers[startingQuestion];
        thirdAnwserBox.GetComponentInChildren<Text>().text = thirdAnwsers[startingQuestion];

        currentQuestion = startingQuestion;
    }

    public void Button1()
    {
        if (correctAnwsers[currentQuestion] == 1)
        {

        }
    }

    public void Button2()
    {
        if (correctAnwsers[currentQuestion] == 2)
        {

        }
    }

    public void Button3()
    {
        if (correctAnwsers[currentQuestion] == 3)
        {

        }
    }

    void Correct()
    {

    }

    void Wrong()
    {

    }
}
