using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
[System.Serializable]

public class Ball : MonoBehaviour
{
    public static Ball current;
    public float maxSpeed = 10f;
   
    void Start()
    {   
        Rigidbody rb = GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
       

    }
    Rigidbody rb; 
    void Update()
    {
        // Trying to Limit Speed
        if (GetComponent<Rigidbody>().velocity.magnitude > maxSpeed)
        {
            GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, maxSpeed);
        }
    }

}