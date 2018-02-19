using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour {
    public Rigidbody rbWall;
    public float incomingForce = -500f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbWall.AddForce(0, 0, incomingForce * Time.deltaTime);
    }
}
