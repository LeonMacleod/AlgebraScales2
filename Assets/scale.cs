using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scale : MonoBehaviour
{

    public List<GameObject> attachedBodies;
    public TextMeshPro massText;



    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (!(attachedBodies.Contains(collision.gameObject)))
        {
            if(collision.gameObject.tag == "CanScale")
            {
                attachedBodies.Add(collision.gameObject);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (attachedBodies.Contains(collision.gameObject))
        {
            if(collision.gameObject.tag == "CanScale")
            {
                attachedBodies.Remove(collision.gameObject);
            }
        }
    }*/


    public float getMassText()
    {
        float mass = 0;
        foreach (GameObject body in attachedBodies)
        {
            mass += body.GetComponent<Rigidbody>().mass;

        }

        return mass;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        massText.text = getMassText().ToString();
    }
}
