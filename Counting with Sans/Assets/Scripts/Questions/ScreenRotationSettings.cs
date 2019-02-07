using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRotationSettings : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        Settings();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Settings()
    {
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;

        Screen.orientation = ScreenOrientation.LandscapeLeft;



    }
}
