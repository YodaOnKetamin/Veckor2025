using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingamemenuscript : MonoBehaviour
{
    [SerializeField]
    GameObject pausemenu;
    
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
    private void togglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
    
}
