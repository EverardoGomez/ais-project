using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Button : MonoBehaviour
{
    int day = 0;

    public void LoadScene(string sceneName){
        if (sceneName == "MainScreen") 
        {
            SceneManager.LoadScene(sceneName);
            day = day + 1;
            Debug.Log(day);
        }
        SceneManager.LoadScene(sceneName);
    }
}
