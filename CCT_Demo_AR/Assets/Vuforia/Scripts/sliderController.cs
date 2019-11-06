using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderController : MonoBehaviour
{
    public Slider slider;
    void Update()
    {
        slider.value = 0f;
        for (float i = 0; i < 1; i += 0.0001f)
        {
            slider.value = i;
        }
    }


}
