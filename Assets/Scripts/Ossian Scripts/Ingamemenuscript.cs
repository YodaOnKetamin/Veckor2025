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
        //m�ste fixa s� att spelet startar igen och allt skit med det! :)
        togglePanel(SettingsPanel);
    }
    private void togglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }

}
