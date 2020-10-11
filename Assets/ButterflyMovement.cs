using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButterflyMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int forceX = 2;
    public int forceY = 2;
    public int forceZ = 2;

    // Update is called once per frame
    void FixedUpdate()
    {
        System.Random rand = new System.Random();
        int X = rand.Next(-forceX, forceX)+1;
        int Y = rand.Next(-1, forceY);
        int Z = rand.Next(-forceZ, forceZ+1);

        rb.AddForce(X, Y, Z);
    }
}
