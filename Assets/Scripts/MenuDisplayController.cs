using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDisplayController : MonoBehaviour
{
    private Canvas menu;

    void Start()
    {
        menu = GetComponent<Canvas>();
        menu.enabled = false;
    }

    public void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            menu.enabled = true;
        }
            
    }

}
