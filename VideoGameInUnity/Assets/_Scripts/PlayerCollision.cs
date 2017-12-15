using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerController P_controller;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            P_controller.enabled = false;
        }
    }
}
