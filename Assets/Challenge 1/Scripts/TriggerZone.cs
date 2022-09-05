/*
 * Devun Schneider
 * Challenge 1
 * Add 1 to score when passing through trigger zones
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            //set the textbox text to You Win!
            triggered = true;
            ScoreManager.score++;
        }
    }
}
