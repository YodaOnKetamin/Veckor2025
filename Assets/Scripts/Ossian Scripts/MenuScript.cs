using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    GameObject quitPanel;
    [SerializeField]
    GameObject MenuPanel;
    [SerializeField]
    GameObject pausespanel;
    public void onStartbuttonpress()
    {
        //scenemanager skit
        print("startar spel");
    }
    public void onQuitbuttonpress()
    {
        TogglePanel(quitPanel);
        TogglePanel(MenuPanel);
    }
    public void onsureQuitbuttonpress()
    {
        print("jag hatar den som klickade här");
        Application.Quit();
    }
    public void Justkiddingilovethisgame()
    {
    
        TogglePanel(quitPanel);
        TogglePanel(MenuPanel);
    }
    private void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }

}