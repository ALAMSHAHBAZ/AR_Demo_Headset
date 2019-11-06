
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;

public class sliderController : MonoBehaviour
{
    public Slider slider;
    private float timeRemaining;
    private const float timerMax = 12f;
   void Start()
    {
        timeRemaining = 0f;
    }

    void Update()
    {
        slider.value = CalculateSliderValue();
            
        
     if (timeRemaining <= timerMax)
        {
            timeRemaining += Time.deltaTime;
            
        }
    }
    float CalculateSliderValue()
    {
        return (timeRemaining/timerMax);
    }


}
