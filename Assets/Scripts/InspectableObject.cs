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

    public void Interact() 
    {
        // TODO: Do interaction code
        Debug.Log("Interacting");
    }

    public void RotateUp() 
    {
        transform.RotateAround(transform.position, new Vector3(1, 0, 0), Time.deltaTime * rotationSpeed);
    }

    public void RotateDown()
    {
        transform.RotateAround(transform.position, new Vector3(-1, 0, 0), Time.deltaTime * rotationSpeed);
    }

    public void RotateLeft()
    {
        transform.RotateAround(transform.position, new Vector3(0, 1, 0), Time.deltaTime * rotationSpeed);
    }

    public void RotateRight() 
    {
        transform.RotateAround(transform.position, new Vector3(0, -1, 0), Time.deltaTime * rotationSpeed);
    }


    public void RotateCW()
    {
        transform.RotateAround(transform.position, new Vector3(0, 0, -1), Time.deltaTime * rotationSpeed);
    }

    public void RotateCCW() 
    {
        transform.RotateAround(transform.position, new Vector3(0, 0, 1), Time.deltaTime * rotationSpeed);
    }

}
