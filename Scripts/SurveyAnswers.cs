using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SurveyAnswers : MonoBehaviour
{    
    float mood = 0;
    public Slider slider;

    public void Update() 
    {  
        mood = slider.value;
        Debug.Log(mood);
    }
}
