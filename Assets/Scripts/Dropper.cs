using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;


    // Start is called before the first frame update
    MeshRenderer renderer;
    Rigidbody rb;    
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        
        renderer.enabled = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait) ;
        {
            renderer.enabled = true;
            rb.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
