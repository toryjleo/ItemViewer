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
        RotateCW();
    }

    public void RotateUp() 
    {
        transform.RotateAround(transform.position, transform.right, Time.deltaTime * rotationSpeed);
    }

    public void RotateDown()
    {
        transform.RotateAround(transform.position, -transform.right, Time.deltaTime * rotationSpeed);
    }

    public void RotateLeft()
    {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * rotationSpeed);
    }

    public void RotateRight() 
    {
        transform.RotateAround(transform.position, -transform.up, Time.deltaTime * rotationSpeed);
    }

    public void RotateCW()
    {
        transform.RotateAround(transform.position, -transform.forward, Time.deltaTime * rotationSpeed);
    }

    public void RotateCCW() 
    {
        transform.RotateAround(transform.position, transform.forward, Time.deltaTime * rotationSpeed);
    }

}
