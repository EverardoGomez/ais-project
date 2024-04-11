using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static SurveyAnswers;

public class Button : MonoBehaviour
{
    public void LoadScene(string sceneName){
        if (sceneName == "Main") 
        {
            SceneManager.LoadScene(sceneName);
            SurveyAnswers.day++;
        }
        SceneManager.LoadScene(sceneName);
    }
}
