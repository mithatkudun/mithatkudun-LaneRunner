using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightfollow : MonoBehaviour
{


    public Light spotlight;
    Transform playerBallTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerBallTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void FixedUpdate() 
    {
        
        this.transform.position = playerBallTransform.position + new Vector3(0, 0.9f, -15);
        spotlight.transform.position = playerBallTransform.position + new Vector3(0, 2, 0);
    }   
}
