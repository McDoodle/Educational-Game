using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BlackFade : MonoBehaviour
{
    public RectTransform Sib;

    public float FadeInTime = 1;
    public float FadedOutTime = 1;
    public float FadeOutTime = 1;

    public bool FNActive = false;
    public bool FDOActive = false;
    public bool FOActive = false;

    public float FadedOutTimer = 0;

    // Update is called once per frame
    void Update()
    {
        FadeUpdate();
        FadeStall();
        FadeEnd();
    }

    public void FadeCall()
    {

        FNActive = true;


    }

    void FadeUpdate()
    {
        if (FNActive)
        {
        Sib.SetAsLastSibling();
            float ChangeAmount = Time.deltaTime / FadeInTime;

            GetComponent<Image>().color = new Color(0, 0, 0, GetComponent<Image>().color.a + ChangeAmount);
            if (GetComponent<Image>().color.a >= 1)
            {

                FNActive = false;
                FDOActive = true;

            }
        }

    }

    void FadeStall()
    {
        if (FDOActive)
        {
            float ChangeAmount = Time.deltaTime / FadedOutTime;

            FadedOutTimer += ChangeAmount;
            if (FadedOutTimer >= 1)
            {
                FadedOutTimer = 0;

                FDOActive = false;
                FOActive = true;

            }
        }
    }

    void FadeEnd()
    {
        if (FOActive)
        {
            float ChangeAmount = Time.deltaTime / FadeOutTime;

            GetComponent<Image>().color = new Color(0, 0, 0, GetComponent<Image>().color.a - ChangeAmount);
            if (GetComponent<Image>().color.a <= 0)
            {

                FOActive = false;
                Sib.SetAsFirstSibling();
            }
        }

    }
}
