using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private bool entered=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if(entered && Input.GetButton("Fire"))
        {
            transform.gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void OnCollisionEnter(Collision c)
    {

            entered = true;
    }
    void OnCollisionExit(Collision c)
    {
        entered = false;
    }
}
