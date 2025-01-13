using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingamemenuscript : MonoBehaviour
{
    [SerializeField]
    GameObject SettingsPanel;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SettingsYes();
        }
    }
    public void SettingsYes()
    {
        togglePanel(SettingsPanel);
    }
    public void Resume()
    {
        //måste fixa så att spelet startar igen och allt skit med det! :)
        togglePanel(SettingsPanel);
    }
    private void togglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }

}
