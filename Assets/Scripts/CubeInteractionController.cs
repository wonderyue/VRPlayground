using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteractionController : CubeController
{
    //rotate variable
    private float rotateSpeed = 360.0F;

    //move variable
    private float speed = 2.0F;

    //color variables
    private bool color = false;
    private Renderer renderer;
    private Color ORIGIN_COLOR;

    //Outline variable
    Outline outline;

    void Start()
    {
        renderer = this.GetComponent<Renderer>();
        ORIGIN_COLOR = renderer.material.GetColor("_Color");
        outline = this.GetComponent<Outline>();
    }

    void Update()
    {
        //outline show when pointing the cube
        outline.enabled = isPointEnter ? true : false;

        //read the game mode
        switch (MenuDisplayController.Mode)
        {
            case MenuDisplayController.MODE.ROTATE_MODE:
                rotate();
                break;
            case MenuDisplayController.MODE.MOVE_MODE:
                move();
                break;
            default:
                break;
        }
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

    //this method should be public and directly linked to the click event
    public void changeColor()
    {
        if (MenuDisplayController.Mode == MenuDisplayController.MODE.COLOR_MODE)
        {
            color = !color;
            renderer.material.SetColor("_Color", color ? Color.red : ORIGIN_COLOR);
        }
    }
}
