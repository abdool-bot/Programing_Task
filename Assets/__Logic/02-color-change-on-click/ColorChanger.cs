using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This script has the function to change the Color of
    the two objects upon calling the methods.

    - First method assigns random colors
    - Second method returns to the default colors
*/

public class ColorChanger : MonoBehaviour
{

    // An exposed list of gameObjects to color multiple objects in a scene
    [SerializeField]
    private GameObject[] targets;
 
    private Renderer objectRenderer;

    private Color newTargetColor;

    private float rValue, bValue, gValue;

    // Update is called once per frame
    public void ChangeObjectColor()
    {
        rValue = Random.Range(0f, 1f);
        gValue = Random.Range(0f, 1f);
        bValue = Random.Range(0f, 1f);

        // loop going through the list of recorded targets from the array
        for(int i = 0; i < targets.Length; i++){
        
        objectRenderer = targets[i].GetComponent<Renderer>();
        newTargetColor = new Color(rValue, gValue, bValue, 1f);

        objectRenderer.material.SetColor("_Color", newTargetColor);

        }
    }

    public void ChangeObjectColorDefault()
    {
        for(int i = 0; i < targets.Length; i++){
        
        objectRenderer = targets[i].GetComponent<Renderer>();
        newTargetColor = new Color(1f, 0.2f, 0.2f, 1f);

        objectRenderer.material.SetColor("_Color", newTargetColor);

        }
    }
}
