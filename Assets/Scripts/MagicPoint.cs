using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPoint : MonoBehaviour
{
    private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        DebugLines(CheckCameraView());
    }

    void DebugLines(bool colorChoice)
    {
        Debug.DrawRay(transform.position, transform.right, colorChoice ? Color.blue : Color.red);
    }

    bool CheckCameraView()
    {
        RaycastHit hit;
        Ray ray = new Ray(camera.transform.position, transform.position);
        Debug.DrawRay(camera.transform.position, transform.position, Color.green);
        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log(hit.transform.position);
            if (hit.transform.position == transform.position)
            {
                return true;
            }
            else return false;
        }
        else return false;
    }
}
