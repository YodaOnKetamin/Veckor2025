using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
   public int Warnings;
   public int lightTreatemnts;
   public int Sanity;//5 - 0

    public bool endGame;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sanity == 5)
        {
            SceneManager.LoadScene("gameOver");
        }

        if (Warnings == 3)
        {
            SceneManager.LoadScene("gameOver");
        }

        if (lightTreatemnts == 3)
        {
            Warnings++;
            lightTreatemnts = 0;
        }

        if (endGame == true)
        {
            if (Sanity + Warnings <= 3)
            {
                SceneManager.LoadScene("PerfectEnding");
            }
            else
            {
                SceneManager.LoadScene("");
            }
        }
        
    }
}
