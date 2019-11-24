using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturePokemon : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float movementSpeed = 50f;
    
    private float hmove = 0f;
    private float vmove = 0f;

    private static CapturePokemon ins;
    private bool anim = false;
    Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        ins = this;
        rb = GetComponent<Rigidbody>();
    }

    //adjust this to change speed
    float speed = 4f;
    //adjust this to change how high it goes
    float height = 0.5f;
    int count = 0;
    int framesUntilStop = 0;
    void Update()
    {
        if (anim == true && framesUntilStop<=12)
        {
            if (count >= 10)
            {
                framesUntilStop++;
            }
            //transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
            // transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed);


            //get the objects current position and put it in a variable so we can access it later with less code
            //   Vector3 pos = GameObject.FindGameObjectWithTag("salvaje").transform.position;
            //calculate what the new Y position will be
            float newX = Mathf.Cos(Time.time * speed);
            if (newX >= 0.99f)
                count++;
            //set the object's Y to the new calculated Y
            transform.position = new Vector3((newX / 6), -0.1f, 6.074f) * height;
        }
        
    }

    internal static void enable(bool v)
    {
        ins.anim = v;
    }
}
