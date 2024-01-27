using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVal : MonoBehaviour
{
	[SerializeField] private Slider slider;
	[SerializeField] public Text val;
	[SerializeField] public GameObject whb;
    
    void Update()
    {
        val.text = slider.value.ToString();
    }
}
