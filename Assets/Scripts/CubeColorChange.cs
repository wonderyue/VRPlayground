using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorChange : MonoBehaviour
{
    private bool color = false;
    private Color ORIGIN_COLOR;

    // Start is called before the first frame update
    void Start()
    {
        //gather the original color
        ORIGIN_COLOR = this.GetComponent<Renderer>().material.GetColor("_Color");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor()
    {
        color = !color;
        if (color)
            this.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        else 
            this.GetComponent<Renderer>().material.SetColor("_Color", ORIGIN_COLOR);
    }
}
