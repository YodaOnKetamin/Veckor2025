using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverScript : MonoBehaviour
{
    public void OnRetryButtonPress()
    {
        SceneManager.LoadScene("Maja");
    }
    public void OnQuitButtonPress()
    {
        print("YOOOOOOO");
        Application.Quit();
    }
}
