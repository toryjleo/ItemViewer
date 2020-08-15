using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ViewerManager : MonoBehaviour
{
    public InspectableObject inspectableObject;

    public float maxZoom = 4.0f;
    public float minZoom = 0.0f;


    private float zoomSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void GetInput() 
    {
        if (Input.GetButton("Right"))
        {
            inspectableObject.RotateRight();
        }
        else if (Input.GetButton("Left"))
        {
            inspectableObject.RotateLeft();
        }

        if (Input.GetButton("Down"))
        {
            inspectableObject.RotateDown();
        }
        else if (Input.GetButton("Up"))
        {
            inspectableObject.RotateUp();
        }

        if (Input.GetButton("ClockWise"))
        {
            inspectableObject.RotateCW();
        }
        else if (Input.GetButton("CounterClockWise"))
        {
            inspectableObject.RotateCCW();
        }

        // Physically move the camera in
        if (Input.GetButton("ZoomIn")) 
        {

            float z = Mathf.Clamp(transform.position.z + Time.deltaTime * zoomSpeed, minZoom, maxZoom);
            transform.position = new Vector3(transform.position.x, transform.position.y, z);
        }
        else if (Input.GetButton("ZoomOut")) 
        {
            float z = Mathf.Clamp(transform.position.z - Time.deltaTime * zoomSpeed, minZoom, maxZoom);
            transform.position = new Vector3(transform.position.x, transform.position.y, z);
        }

        if (Input.GetButtonDown("Interact")) 
        {
            inspectableObject.Interact();
        }
    }
}
