using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionStorage : MonoBehaviour
{
    //Stores the four buttons for the script to reference
    public GameObject questionBox;
    public GameObject firstAnwserBox;
    public GameObject secondAnwserBox;
    public GameObject thirdAnwserBox;

    //Stores the player to send animation information to
    public GameObject player;

    //Integer Array for the Anwsers
    public int[] correctAnwsers;

    //String Arrays for storing Questions and Choices
    public string[] questions;
    public string[] firstAnwsers;
    public string[] secondAnwsers;
    public string[] thirdAnwsers;

    //Sets the starting question and keeps track of the current question
    public int startingQuestion = 1;
    public int currentQuestion;

    // Start is called before the first frame update
    void Start()
    {
        InstaniatingQuestions();
        Debug.Log(questions.Length);
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
            Correct(1);
        }
        else
        {
            Wrong(1);
        }
    }

    public void Button2()
    {
        if (correctAnwsers[currentQuestion] == 2)
        {
            Correct(2);
        }
        else
        {
            Wrong(2);
        }
    }

    public void Button3()
    {
        if (correctAnwsers[currentQuestion] == 3)
        {
            Correct(3);
        }
        else
        {
            Wrong(3);
        }
    }

    void Correct(int button)
    {

        //ChangeButtonText();

        player.GetComponent<PlayerAnimatorScript>().RunAnimation(button, false);

    }

    void Wrong(int button)
    {
        player.GetComponent<PlayerAnimatorScript>().RunAnimation(button, true);
    }

    //Increments the currentQuestion by one and updates the buttons text.
    public void ChangeButtonText()
    {
        //Checks if there are more questions
        if (questions.Length > currentQuestion)
        {

            currentQuestion += 1;
            questionBox.GetComponentInChildren<Text>().text = questions[currentQuestion];
            firstAnwserBox.GetComponentInChildren<Text>().text = firstAnwsers[currentQuestion];
            secondAnwserBox.GetComponentInChildren<Text>().text = secondAnwsers[currentQuestion];
            thirdAnwserBox.GetComponentInChildren<Text>().text = thirdAnwsers[currentQuestion];

        }
    }



}
