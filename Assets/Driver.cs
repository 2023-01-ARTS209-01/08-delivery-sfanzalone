using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 1f; //Changing this value INVERTS the controls
    [SerializeField] private float driveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmt = Input.GetAxis("Horizontal") * steerSpeed; //Changing steerSpeed INVERTS the controls
        float moveAmt = Input.GetAxis("Vertical") * driveSpeed; //Changes vertical movement

        transform.Rotate(0, 0, -steerAmt); //Making steerAmt POSITIVE will INVERTS the controls
        //transform.Translate(0, driveSpeed, 0);
        transform.Translate(0, moveAmt, 0);
    }
}