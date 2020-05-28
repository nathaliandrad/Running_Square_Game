using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rigdBody;
    public float forwardForce = 2000f;


    // Update is called once per frame
    //fixed update when using or calculating forces
    void FixedUpdate()
    {
        rigdBody.AddForce(0, 0, forwardForce * Time.deltaTime);
    }

}
