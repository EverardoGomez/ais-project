using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValueUpdate : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI sliderText;
    
    public float day = 0;

    // Update is called once per frame
    void Update()
    {
        sliderText.text = slider.value.ToString();
        SingletonData.instance.mood = (float)slider.value;
        day++;
    }
}
