using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    [SerializeField] Slider slider;

    public void SetMaxHealth(int health) 
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health) 
    {
        slider.value = health;
    }

}
