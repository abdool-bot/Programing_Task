using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This script has the function to rotate the sphere 
    around a given object with adjustable rotation speed
*/

public class OrbitAroundCube : MonoBehaviour
{
    // Exposed variable to assign the affected object to it
    [SerializeField]
    private GameObject target;

    private float rotationSpeed = 50;

    // A public method exposed to be used inside the editor through commands like onClick() or onValueChanged()
    public void sliderRotation(float rotValue){
        rotationSpeed = rotValue;
    }

    // Update is called once per frame
    void Update()
    {
        // Transforming the position of the target (sphere) frame by frame with this method provided by Unity
        transform.RotateAround(target.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
