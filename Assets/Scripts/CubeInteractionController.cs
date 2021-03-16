using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteractionController : CubeController
{
    private float rotateSpeed = 360.0F;
    private int mode = 0;
    private float speed = 2.0F;

    private bool color = false;
    private Renderer renderer;
    private Color ORIGIN_COLOR;

    void Start()
    {
        renderer = this.GetComponent<Renderer>();
        ORIGIN_COLOR = renderer.material.GetColor("_Color");
    }

    void Update()
    {
        mode = MenuModeController.mode;
        if (mode == 1)
            rotate();

        else if (mode == 2)
            move();
        
        else if (mode == 3)
            changeColor();

    }

    void rotate()
    {
        if (isPointEnter && isPointDown)
            transform.Rotate(0, Time.deltaTime * rotateSpeed, 0);
    }

    void move()
    {
        if (isPointEnter && isPointDown)
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void changeColor() 
    {
        if (isPointClick)
        {
            isPointClick = !isPointClick;
            color = !color;
            renderer.material.SetColor("_Color", color? Color.red : ORIGIN_COLOR);
        }
    }

}
