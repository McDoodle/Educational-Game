﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour {

	public void NewGame()
    {
        SceneManager.LoadScene("JasonScrapYard");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
