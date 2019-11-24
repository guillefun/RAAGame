using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCshowTienda : MonoBehaviour
{
    // Start is called before the first frame update
    private bool entered = false;
    public GameObject tienda;
    void Start()
    {
        
    }

    void Update()
    {
        if (entered && Input.GetButton("Fire"))
        {
            tienda.SetActive(true);
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
        tienda.SetActive(false);
    }
}
