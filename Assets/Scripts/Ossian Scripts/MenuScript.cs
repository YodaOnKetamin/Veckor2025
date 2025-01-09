using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    GameObject SettingsPanel;
    [SerializeField]
    GameObject MenuPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onbuttonpress()
    {
        SettingsPanel.SetActive(!SettingsPanel.activeSelf);
        MenuPanel.SetActive(!MenuPanel.activeSelf);
    }
}
