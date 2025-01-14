using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene("Maja");
    }
    public void onQuitbuttonpress()//togglar mellan meny och quit
    {
        TogglePanel(quitPanel);
        TogglePanel(MenuPanel);
    }
    public void onsureQuitbuttonpress()//avslutar spelet
    {
        print("jag hatar den som klickade här");
        Application.Quit();
    }
    public void Justkiddingilovethisgame()
    {//går tillbaks till quitmenyn
    
        TogglePanel(quitPanel);
        TogglePanel(MenuPanel);
    }
    private void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
    public void GameOver()
    {
        //startar om spel ska byta sen
        print("jag vete fan");
        SceneManager.LoadScene("Maja");
    }

}