using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour
{
    int Warnings;
    int lightTreatemnts;
   public int Sanity;//5 - 0

    bool endGame;

    treatments T;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<treatments>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Sanity == 0)
        {
            //loss
        }

        if (Warnings == 3)
        {
            //loss
        }
        
        if (endGame == true)
        {
            if (Sanity + Warnings <= 3)
            {
                //good ending
            }
            else
            {
                //bad ending
            }
        }
        
    }
}
