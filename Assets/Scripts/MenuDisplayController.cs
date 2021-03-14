using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDisplayController : MonoBehaviour
{
    private bool isShowing = false;
    private Canvas menu;

    void Start()
    {
        menu = GetComponent<Canvas>();
        menu.enabled = isShowing;
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
            toggleMenu();
    }

    public void toggleMenu()
    {
        isShowing = !isShowing;
        menu.enabled = isShowing;        
    }
}
