using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectableObject : MonoBehaviour
{
    public float rotationSpeed = 90f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void RotateUp() 
    {
    
    }

    public void RotateLeft()
    {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * rotationSpeed);
    }

    void RotateRight() 
    {
        transform.RotateAround(transform.position, transform.up, -Time.deltaTime * rotationSpeed);
    }
}
