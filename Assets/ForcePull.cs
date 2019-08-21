using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePull : MonoBehaviour
{


    public GameObject lastObjectLookedAt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Bit shift the index of the layer (10) to get a bit mask
        int layerMask = 1 << 10;


        RaycastHit hit;
        // Does the ray coming directly out of the camera (where user is looking directly) hit any of the pickupable objects. (LAYER 10 = pickupable)
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            // Used to re-enable gravity.
            lastObjectLookedAt = hit.transform.gameObject;
            //Disabling gravity (object is being force pulled towards user) unless object is in players hands.
            if(hit.transform.gameObject.transform.Find("isHeld").tag == "false")
            {
                hit.transform.gameObject.GetComponent<Rigidbody>().useGravity = false;
            }
            

            // If the distance between the object being force pulled and the camera is less than one unit it will no longer be pulled. (suspended in air (no gravity))
            // If the object in question is already being held it will not experience a force.
            if(Vector3.Distance(hit.transform.gameObject.transform.position, this.transform.position) > 1f && hit.transform.gameObject.transform.Find("isHeld").tag == "false")
            {
                hit.transform.gameObject.transform.position = Vector3.MoveTowards(hit.transform.gameObject.transform.position, this.transform.position, 0.10f);
            }
            
        }
        else
        {

            //Re-enabling gravity.
            lastObjectLookedAt.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
