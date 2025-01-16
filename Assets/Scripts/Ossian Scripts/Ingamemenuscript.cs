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
        //m�ste fixa s� att spelet startar igen och allt skit med det! :)
        togglePanel(pausemenu);
    }
    private void togglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
    
}
