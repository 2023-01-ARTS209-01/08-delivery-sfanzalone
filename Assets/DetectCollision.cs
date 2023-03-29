using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    //Instance variables for class
    private bool hasPackage = false;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("We hit something!! - " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        //Debug.Log("We went through a trigger!! - " + trigger.gameObject.name);

        if (trigger.gameObject.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up package");
            hasPackage = true;
        }

        if (trigger.gameObject.CompareTag("Goal") && hasPackage)
        {
            Debug.Log("Package has been delivered!  You Win!");
            hasPackage = false;
        }
    }
}