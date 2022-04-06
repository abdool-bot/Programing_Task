using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitAroundCube : MonoBehaviour
{

    // SerializeField 
    [SerializeField]
    private GameObject target;

    private float rotationSpeed = 50;

    public void sliderRotation(float rotValue){
        rotationSpeed = rotValue;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
