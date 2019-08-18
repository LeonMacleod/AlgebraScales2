using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{


    private GameObject scale1;
    private GameObject scale2;




    private void OnCollisionEnter(Collision collision)
    {





        //dealing with the first scale or object on top of it or object on top of the object on top of it.



        if(collision.gameObject.name == "scale1")
        {
            if (this.gameObject.transform.Find("state").tag == "notadded")
            {
                Debug.Log(this.gameObject.name + " has collided with scale1");
                this.gameObject.transform.Find("id").tag = "scale1";
                this.gameObject.transform.Find("state").tag = "added";
                scale1.GetComponent<scale>().attachedBodies.Add(this.gameObject);
            }


            
        }
        else
        {

            if(collision.gameObject.transform.Find("id") != null)
            {
                if (collision.gameObject.transform.Find("id").tag == "scale1")
                {

                    if (this.gameObject.transform.Find("state").tag == "notadded")
                    {
                        Debug.Log(this.gameObject.name + " has collided with scale1");
                        this.gameObject.transform.Find("id").tag = "scale1";
                        this.gameObject.transform.Find("state").tag = "added";
                        scale1.GetComponent<scale>().attachedBodies.Add(this.gameObject);

                    }



                }
            }
        
            


        }





        


        if (collision.gameObject.name == "scale2")
        {
            if (this.gameObject.transform.Find("state").tag == "notadded")
            {
                Debug.Log(this.gameObject.name + " has collided with scale2");
                this.gameObject.transform.Find("id").tag = "scale2";
                this.gameObject.transform.Find("state").tag = "added";
                scale2.GetComponent<scale>().attachedBodies.Add(this.gameObject);
            }



        }
        else
        {

            if(collision.gameObject.transform.Find("id") != null)
            {

                if (collision.gameObject.transform.Find("id").tag == "scale2")
                {

                    if (this.gameObject.transform.Find("state").tag == "notadded")
                    {
                        Debug.Log(this.gameObject.name + " has collided with scale2");
                        this.gameObject.transform.Find("id").tag = "scale2";
                        this.gameObject.transform.Find("state").tag = "added";
                        scale2.GetComponent<scale>().attachedBodies.Add(this.gameObject);

                    }



                }
            }
            


        }
        



    }

       



        //dealing with the second scale or object on top of it or object on top of the object on top of it.

        /*
        
        if (collision.gameObject.name == "scale2" || collision.gameObject.transform.Find("id").tag == "scale2")
        {

            if (this.gameObject.transform.Find("state").tag == "notadded")
            {
                Debug.Log(this.gameObject.name + " has collided with scale2");
                this.gameObject.transform.Find("id").tag = "scale2";
                this.gameObject.transform.Find("state").tag = "added";
                scale2.GetComponent<scale>().attachedBodies.Add(this.gameObject);
            }





        }
        
        */

    


    private void OnCollisionExit(Collision collision)
    {
      

    }




    // Start is called before the first frame update
    void Start()
    {
        scale1 = GameObject.Find("scale1");
        scale2 = GameObject.Find("scale2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
