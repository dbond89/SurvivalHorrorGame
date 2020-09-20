using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Handles the rotation for the Lighthouse Light within HorrorScene
 */
public class LighthouseRotation : MonoBehaviour
{
    // For linking the Lighthouse Light gameobject
    [SerializeField] GameObject LighthouseLightObject;
    // The speed at which the lighthouse light will rotate
    [SerializeField] float RotationSpeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        LighthouseLightObject.transform.Rotate(0.0f, RotationSpeed, 0.0f, Space.World);
    }
}
