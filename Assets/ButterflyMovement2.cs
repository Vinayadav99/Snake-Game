using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyMovement2 : MonoBehaviour
{
    public Rigidbody rb;

    public float minSpeed;  // minimum range of speed to move
    public float maxSpeed;  // maximum range of speed to move
    float speed;

    float step = Mathf.PI / 60;
    float timeVar = 0;
    float rotationRange = 270;                  //  How far should the object rotate to find a new direction?
    float baseDirection = 0;
    Vector3 randomDirection;
    // Update is called once per frame
    void Update()
    {

        randomDirection = new Vector3(0, Mathf.Sin(timeVar) * (rotationRange / 2) + baseDirection, 0); //   Moving at random angles 
        timeVar += step;
        speed = Random.Range(minSpeed, maxSpeed);              //      Change this range of numbers to change speed
        GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        transform.Rotate(randomDirection * Time.deltaTime * 1.0f);
    }
}
