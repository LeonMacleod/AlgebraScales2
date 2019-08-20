using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        // any object pickupable by a user simply has an empty object called "pickup" on it.
        if (collision.gameObject.transform.Find("pickup") != null)
        {

            //if fixed joint exists on next collision it will be destroyed to make way for the new hand holding (allows user to pass object between two hands)
            if (collision.gameObject.GetComponents<FixedJoint>().Length == 1)
            {
                Destroy(collision.gameObject.GetComponent<FixedJoint>());
                collision.gameObject.AddComponent<FixedJoint>().connectedBody = this.gameObject.GetComponent<Rigidbody>();
                collision.gameObject.transform.Find("pickup").tag = this.gameObject.name;

            }
            // if no fixed joint exists one will be created.
            else if (collision.gameObject.GetComponents<FixedJoint>().Length == 0)
            {


                collision.gameObject.AddComponent<FixedJoint>().connectedBody = this.gameObject.GetComponent<Rigidbody>();
                collision.gameObject.transform.Find("isHeld").tag = "true";
                collision.gameObject.transform.Find("pickup").tag = this.gameObject.name;

            }


        }


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // DROP OBJECTS in HANDS
        if (Input.GetButton("LeftTriggerPress"))
        {

            // All objects in the scene with the tag 'true', these ar eput on isHeld identification objects
            GameObject[] heldObjects = GameObject.FindGameObjectsWithTag("LHand");
            foreach(GameObject go in heldObjects)
            {

                // Destroying the fixedjoint on objects connected to the left hand.
                Destroy(go.GetComponentInParent<FixedJoint>());

            }

        }


        if (Input.GetButton("RightTriggerPress"))
        {

          
            GameObject[] heldObjects = GameObject.FindGameObjectsWithTag("RHand");
            foreach (GameObject go in heldObjects)
            {

                // Destroying the fixedjoint on objects connected to the right hand.
                Destroy(go.GetComponentInParent<FixedJoint>());

            }

        }



        //if(Input.GetButton("RightTri"))



    }
}
