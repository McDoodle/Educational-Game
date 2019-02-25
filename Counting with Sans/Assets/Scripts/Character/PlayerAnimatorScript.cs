using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorScript : MonoBehaviour
{

    public GameObject InformationMaster;
    public GameObject FadeImage;

    public float AnimationTime;
    public float time = 0f;
    public bool Run = false;
    public bool Wrong = true;

    private void Update()
    {
        TimerFunction();
    }

    public void RunAnimation(int button, bool wrong)
    {
        GetComponent<Animator>().SetBool("Force Idle", false);

        if (button == 1)
        {
            GetComponent<Animator>().SetBool("Door1", true);
            GetComponent<Animator>().SetBool("Door2", false);
            GetComponent<Animator>().SetBool("Door3", false);
        }
        else if (button == 2)
        {
            GetComponent<Animator>().SetBool("Door1", false);
            GetComponent<Animator>().SetBool("Door2", true);
            GetComponent<Animator>().SetBool("Door3", false);
        }
        else if (button == 3)
        {
            GetComponent<Animator>().SetBool("Door1", false);
            GetComponent<Animator>().SetBool("Door2", false);
            GetComponent<Animator>().SetBool("Door3", true);
        }

        if (wrong)
        {
            GetComponent<Animator>().SetBool("Wrong", true);
            Wrong = true;
        }
        else
        {
            Debug.Log("wrong = false");
            GetComponent<Animator>().SetBool("Wrong", false);
            Wrong = false;
        }

        Run = true;

    }

    void TimerFunction()
    {
         if (Run)
        {
            time += Time.deltaTime;
            if (time > AnimationTime)
            {
                time = 0;
                Run = false;

                GetComponent<Animator>().SetBool("Door1", false);
                GetComponent<Animator>().SetBool("Door2", false);
                GetComponent<Animator>().SetBool("Door3", false);

                if (!Wrong)
                {
                    InformationMaster.GetComponent<QuestionStorage>().ChangeButtonText();


                    GetComponent<Animator>().SetBool("Force Idle", true);

                    time = 0;
                    Run = false;
                }

            } else if (time > 1 && GetComponent<Animator>().GetBool("Door2") == true)
            {
                if (!Wrong)
                {
                    FadeImage.GetComponent<BlackFade>().FadeCall();
                }
            } else if (time > 2)
            {
                if (!Wrong)
                {
                    FadeImage.GetComponent<BlackFade>().FadeCall();
                }
            }


        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
    }

}
