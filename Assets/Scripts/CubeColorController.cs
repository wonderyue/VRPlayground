using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorController : MonoBehaviour
{
    private bool color = false;
    private Renderer renderer;
    private Color ORIGIN_COLOR;

    void Start()
    {
        renderer = this.GetComponent<Renderer>();
        ORIGIN_COLOR = renderer.material.GetColor("_Color");
    }

    public void changeColor()
    {
        color = !color;
        renderer.material.SetColor("_Color", color ? Color.red : ORIGIN_COLOR);
    }
}
