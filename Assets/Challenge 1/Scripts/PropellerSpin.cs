/*
 * Devun Schneider
 * Challenge 1
 * Plane propeller animation
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    private float propellorSpeed = 1000;
    
    void Update()
    {
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
    }
}
