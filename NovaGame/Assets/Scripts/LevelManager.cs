﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

class LevelManager
{
    public void LoadLevel(string name) {
        Debug.Log("Request for: " + name);
        SceneManager.LoadScene(name);
    }

    public void QuitRequest() {
        Debug.Log("I want to quit");
        Application.Quit();
    }
}
