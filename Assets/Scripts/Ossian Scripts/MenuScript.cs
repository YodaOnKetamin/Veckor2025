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

    public void onStartbuttonpress()
    {
        //scenemanager skit
        print("startar spel");
        SceneManager.LoadScene("BlackScreenScene");
    }
    public void onQuitbuttonpress()//togglar mellan meny och quit
    {
        TogglePanel(quitPanel);
        TogglePanel(MenuPanel);
    }
    public void onsureQuitbuttonpress()//avslutar spelet
    {
        print("jag hatar den som klickade h�r");
        Application.Quit();
    }
    public void Justkiddingilovethisgame()
    {//g�r tillbaks till quitmenyn
    
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
        print("jag vete fan"); //ligger p� ingame menu ska fixa n�got sen
        SceneManager.LoadScene("Ossian Scene");
    }
    public void BeginGame()
    {
        SceneManager.LoadScene("Maja");
    }

}