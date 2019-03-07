using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionAfterSeconds : MonoBehaviour
{
    public float TimeBeforeTransition = 5f;
    public string SceneToTransitionTo = "MainMenu";

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerIncrement();
    }

    void TimerIncrement()
    {

        timer += Time.deltaTime;

        if(timer >= TimeBeforeTransition)
        {

            SceneChange();

        }

    }

    void SceneChange()
    {

        Debug.Log("Transition");

        SceneManager.LoadScene(SceneToTransitionTo);

    }


}
