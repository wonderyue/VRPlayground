using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuModeController : MonoBehaviour
{
    public static int mode = 0;
    private Canvas menu;
    void Start()
    {
        menu = GameObject.Find("Canvas").GetComponent<Canvas>();
    }

    public void getMode() 
    {
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        if (btnName == "RotateBtn")
            mode = 1;
        else if (btnName == "MoveBtn")
            mode = 2;
        else if (btnName == "ColorBtn")
            mode = 3;
        else if (btnName == "ClearBtn")
            mode = 0;
        hideMenu();
    }

    public void hideMenu() 
    {
        menu.enabled = false;
    }
}
