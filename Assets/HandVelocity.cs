using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandVelocity : MonoBehaviour
{

    public Vector3 lastPosition;

    public Vector3 currentPosition;

    public Vector3 velocity;


    // Start is called before the first frame update
    void Start()
    {
        lastPosition = this.gameObject.transform.position;
        currentPosition = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocity = this.transform.position - lastPosition;

        lastPosition = this.gameObject.transform.position;
        currentPosition = this.gameObject.transform.position;

        
    }
}
