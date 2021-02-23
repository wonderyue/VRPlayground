using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoveController : CubeController
{
    private float speed = 2.0F;

    void Update()
    {
        if (isPointEnter && isPointDown)
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
