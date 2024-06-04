using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageFloat : MonoBehaviour
{
    public float floatSpeed = 2f; // Speed of floating
    public float floatMagnitude = 5f; // How high it floats

    private Vector3 originalLocalPosition;
    private Transform myTransform;

    void Start()
    {
        myTransform = transform;
        originalLocalPosition = myTransform.localPosition; // Use localPosition for UI elements or child objects
    }

    void Update()
    {
        // Sin wave for smooth oscillation
        float newY = Mathf.Sin(Time.time * floatSpeed) * floatMagnitude;
        myTransform.localPosition = originalLocalPosition + new Vector3(0, newY, 0); // Update the local position
    }
}
