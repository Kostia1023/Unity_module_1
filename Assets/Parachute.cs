using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parachute : MonoBehaviour
{
    private Rigidbody rb;
    private bool isOpen = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log(Vector3.Angle(new Vector3(1, 5, -7), new Vector3(8,0,-6)));
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && !isOpen)
        {
            rb.drag = 7;
            isOpen= true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!isOpen)
        {
            Debug.Log("you die");
        }
        else
        {
            Debug.Log("you are saved");
        }
    }
}
