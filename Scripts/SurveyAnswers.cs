using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurveyAnswers : MonoBehaviour
{
    float mood = 0;
    public static float day = 0;

    public Slider slider;

    void Update() 
    {  
        mood = slider.value;
    }
}
