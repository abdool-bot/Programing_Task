using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationSpeedDisplayer : MonoBehaviour

{
    public Text handleText;

    void Start()
    {
        handleText = GetComponent<Text>();
    }
    
    public void textUpdater(float value)
    {
        handleText.text = Mathf.RoundToInt(value) + "";    
    }
}
