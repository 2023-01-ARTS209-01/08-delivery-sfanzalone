using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("We hit something!! - " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        //Debug.Log("We went through a trigger!! - " + trigger.gameObject.name);

        if (trigger.gameObject.CompareTag("Package"))
        {
            Debug.Log("I have picked up a package!");
        }

        if (trigger.gameObject.CompareTag("Goal"))
        {
            Debug.Log("I have delivered the package!");
        }
    }
}