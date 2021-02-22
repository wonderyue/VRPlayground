using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotateController : CubeController
{
    public float rotateSpeed = 360.0F;
    void Update()
    {
        if (isPointEnter && isPointDown)
            transform.Rotate(0, Time.deltaTime * rotateSpeed, 0);
    }
}
