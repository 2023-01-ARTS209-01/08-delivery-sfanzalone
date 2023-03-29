using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObjectives : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "Goal")
        {
            Debug.Log("You reached the " + trigger.gameObject.name + "!");
        }
    }
}