using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject clipboardUp;
    public GameObject clipboardDown;
    public GameObject patient1Dialogue1;
    public GameObject patient1Dialogue2;
    public GameObject patient1Dialogue3;
    public GameObject patient1Dialogue4;

    public Dialogue dialogueScript;

    public void Update()
    {
        
    }

    public void Clipboard()
    {
        clipboardUp.SetActive(true);
        clipboardDown.SetActive(false);
    }

    public void putDownClipboard()
    {
        clipboardUp.SetActive(false);
        clipboardDown.SetActive(true);
    }

    //frågor
    public void questionOne()
    {
        patient1Dialogue1.SetActive(true);
        putDownClipboard();
    }

    public void questionTwo()
    {
        patient1Dialogue2.SetActive(true);
        putDownClipboard();
    }

    public void questionThree()
    {
        patient1Dialogue3.SetActive(true);
        putDownClipboard();
    }

    public void questionFour()
    {
        patient1Dialogue4.SetActive(true);
        putDownClipboard();
    }

    public void questionFive()
    {
        putDownClipboard();
    }
}
