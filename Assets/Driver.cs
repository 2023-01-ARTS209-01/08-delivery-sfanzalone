using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 30f; //Changing this value INVERTS the controls
    [SerializeField] private float driveSpeed = 10f;
    private bool hasBoost = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmt = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime; //Changing steerSpeed INVERTS the controls
        float moveAmt = Input.GetAxis("Vertical") * driveSpeed * Time.deltaTime; //Changes vertical movement

        transform.Rotate(0, 0, -steerAmt); //Making steerAmt POSITIVE will INVERTS the controls
        //transform.Translate(0, driveSpeed, 0);
        transform.Translate(0, moveAmt, 0);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Speed Boost") && !hasBoost)
        {
            Debug.Log("Speed Up!");
            hasBoost = true;
            driveSpeed = 15f;
        }

        if (trigger.gameObject.CompareTag("Anti-boost") && hasBoost)
        {
            Debug.Log("Slow Down!");
            hasBoost = false;
            driveSpeed = 10f;
        }
    }
}