using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject clipboardUp;
    public GameObject clipboardDown;
    public GameObject checkedFileDialogue;
    public GameObject adamTreatmentResponse;
    public GameObject checkedTreatmentDialogue;
    public GameObject patient1Dialogue1;
    public GameObject patient1Dialogue2;
    public GameObject patient1Dialogue3;
    public GameObject patient1Dialogue4;
    public GameObject patient1Dialogue5;

    public bool checkedTreatment = false;

    public Button checkboardDown_;

    private void Start()
    {
        checkboardDown_.enabled = false;
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

    public void checkedFile()
    {
        checkedFileDialogue.SetActive(true);
        checkboardDown_.enabled = true;
    }

    public void checkedTreatmentPage()
    {
        checkedTreatment = true;
    }

    public void done()
    {
        if(checkedTreatment == true)
        {
            checkedTreatmentDialogue.SetActive(true);
            putDownClipboard();
        }
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
        patient1Dialogue5.SetActive(true);
        putDownClipboard();
    }

    public void treatmentResponse()
    {
        adamTreatmentResponse.SetActive(true);
    }
}
