using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    This script has the function to display the current
    rotation value on the canvas
*/

public class RotationSpeedDisplayer : MonoBehaviour
{
    // Exposed variable to assign the text that should be affected
    public Text handleText;

    void Start()
    {
        handleText = GetComponent<Text>();
    }
    
    public void textUpdater(float value)
    {
        // displaying the value as a string
        handleText.text = Mathf.RoundToInt(value) + "";    
    }
}
