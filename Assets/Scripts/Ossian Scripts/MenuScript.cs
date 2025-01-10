using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    GameObject Surequitpanel;
    [SerializeField]
    GameObject quitPanel;
    [SerializeField]
    GameObject SettingsPanel;
    [SerializeField]
    GameObject MenuPanel;
    [SerializeField]
    GameObject pausespanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onStartbuttonpress()
    {
        //scenemanager skit
        print("startar spel");
    }
    public void onQuitbuttonpress()
    {
        quitPanel.SetActive(!quitPanel.activeSelf);
        MenuPanel.SetActive(!MenuPanel.activeSelf);
    }
    public void onsureQuitbuttonpress()
    {
        print("jag hatar den som klickade här");
        Application.Quit();
    }
    public void Justkiddingilovethisgame()
    {
        quitPanel.SetActive(!quitPanel.activeSelf);
        MenuPanel.SetActive(!MenuPanel.activeSelf);
    }
    public void settingsbutton()
    {
        /* SettingsPanel.SetActive(!SettingsPanel.activeSelf);
         MenuPanel.SetActive(!MenuPanel.activeSelf);*/
    }

}
