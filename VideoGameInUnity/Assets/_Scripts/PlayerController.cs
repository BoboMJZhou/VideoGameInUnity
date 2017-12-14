using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        Debug.Log("LA");
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("LA UPDATE");
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, 0, 2000)*Time.deltaTime);
    }
}
