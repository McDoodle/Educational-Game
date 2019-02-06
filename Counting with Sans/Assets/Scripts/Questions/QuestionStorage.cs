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

    public string[] questions;
    public string[] firstAnwsers;
    public string[] secondAnwsers;
    public string[] thirdAnwsers;

    public int currentQuestion = 1;

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
        questionBox.GetComponentInChildren<Text>().text = questions[1];
        firstAnwserBox.GetComponentInChildren<Text>().text = firstAnwsers[1];
        secondAnwserBox.GetComponentInChildren<Text>().text = secondAnwsers[1];
        thirdAnwserBox.GetComponentInChildren<Text>().text = thirdAnwsers[1];
    }


}
