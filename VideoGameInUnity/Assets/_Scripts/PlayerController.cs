using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private void FixedUpdate()
    {
        // Add forwardforce
        //rb.velocity = transform.forward * forwardForce * Time.deltaTime;
        rb.AddForce(new Vector3(0, 0, forwardForce) *Time.deltaTime);

        //
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<Game_manager>().EndGame();
        }
    }
}
