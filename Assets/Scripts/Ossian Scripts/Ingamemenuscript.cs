using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ingamemenuscript : MonoBehaviour
{
    [SerializeField]
    GameObject pausemenu;
    [SerializeField]
    GameObject GameOverMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausemenu();
        }
    }
    public void Pausemenu()
    {
        togglePanel(pausemenu);
    }
    public void Resume()
    {
        //måste fixa så att spelet startar igen och allt skit med det! :)
        togglePanel(pausemenu);
    }
    public void GameOver()
    {
        togglePanel(GameOverMenu);
    }
    private void togglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
    
}
