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

    //Sets the button text to the starting question
    void InstaniatingQuestions()
    {
        questionBox.GetComponentInChildren<Text>().text = questions[startingQuestion];
        firstAnwserBox.GetComponentInChildren<Text>().text = firstAnwsers[startingQuestion];
        secondAnwserBox.GetComponentInChildren<Text>().text = secondAnwsers[startingQuestion];
        thirdAnwserBox.GetComponentInChildren<Text>().text = thirdAnwsers[startingQuestion];

        currentQuestion = startingQuestion;
    }

    // Button1, Button2 & Button3 all check if the answer is the same as their number.
    public void Button1()
    {
        if (correctAnwsers[currentQuestion] == 1)
        {
            Correct();
        }
        else
        {
            Wrong();
        }
    }

    public void Button2()
    {
        if (correctAnwsers[currentQuestion] == 2)
        {
            Correct();
        }
        else
        {
            Wrong();
        }
    }

    public void Button3()
    {
        if (correctAnwsers[currentQuestion] == 3)
        {
            Correct();
        }
        else
        {
            Wrong();
        }
    }

    void Correct()
    {

        ChangeButtonText();




    }

    void Wrong()
    {

    }

    //Increments the currentQuestion by one and updates the buttons text.
    void ChangeButtonText()
    {
        currentQuestion += 1;

        questionBox.GetComponentInChildren<Text>().text = questions[currentQuestion];
        firstAnwserBox.GetComponentInChildren<Text>().text = firstAnwsers[currentQuestion];
        secondAnwserBox.GetComponentInChildren<Text>().text = secondAnwsers[currentQuestion];
        thirdAnwserBox.GetComponentInChildren<Text>().text = thirdAnwsers[currentQuestion];
    }


}
