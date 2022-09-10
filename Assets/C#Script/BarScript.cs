using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarScript : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxEnergy(int energy){
        slider.maxValue = 500;
        slider.value = energy;

        fill.color = gradient.Evaluate(1f);
    }
    public void SetMaxHappy(int happy){
        slider.maxValue = 500;
        slider.value = happy;

        fill.color = gradient.Evaluate(1f);
    }
    public void SetEnergy(int energy){
 
        slider.value = energy;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
       public void SetHappy(int happy){
 
        slider.value = happy;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
   

}
