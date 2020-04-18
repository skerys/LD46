﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBarScript : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] float timerMultiplayer;

    [SerializeField] Gradient gradient;
    [SerializeField] Image fill;

    [SerializeField] bool isDecreasing = false;

    public void SetValue(int value)
    {
        slider.value = value;
    }

    public void SetMaxValue(int value)
    {
        Debug.Log(value);
        slider.maxValue = value;
        slider.value = value;
    }

    private void Update() 
    {
        if (isDecreasing) slider.value -= timerMultiplayer * Time.deltaTime;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void AddSliderValue(int amount)
    {
        slider.value += amount;
    }

    public void DecreaseSliderValue( int amount)
    {
        slider.value -= amount;
    }
}