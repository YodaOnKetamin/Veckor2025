using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//2 3 2 2 2
public class chekcmarks : MonoBehaviour
{
    Toggle toggle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle.enabled == true)
        {
            toggle.interactable = false;
        }
    }
}
