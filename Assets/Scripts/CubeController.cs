using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    protected bool isPointEnter = false;
    protected bool isPointDown = false;
    // protected bool isPointClick = false;

    public void PointEnter()
    {
        isPointEnter = true;
    }

    public void PointExit()
    {
        isPointEnter = false;
    }

    public void PointUp()
    {
        isPointDown = false;
    }
    
    public void PointDown()
    {
        isPointDown = true;
    }

    // public void PointClick()
    // {
    //     isPointClick = true;        
    // }

}
