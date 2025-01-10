using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingamemenuscript : MonoBehaviour
{
    [SerializeField]
    GameObject SettingsPanel;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Settingsyes();
        }
    }
    public void Settingsyes()
    {
        togglePanel(SettingsPanel);
    }
    private void togglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
}
