using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This script has the function to make it possible
    through clicking to change the color when the 
    mouse is visibly hovering over an object 
*/

public class ColorChangerClick : MonoBehaviour
{
    [SerializeField]
    private GameObject colorChanger;

    // Update is called once per frame
   void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Ray toMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rhInfo;

            bool onObject = Physics.Raycast(toMouse, out rhInfo, 12f);

            if(onObject && gameObject.tag.Equals("Body")) {
                colorChanger.GetComponent<ColorChanger>().ChangeObjectColor();
            }
        }
    }
}
