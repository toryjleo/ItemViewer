using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewerManager : MonoBehaviour
{
    public InspectableObject inspectableObject;

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
    }
}
