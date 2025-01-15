using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject clipboardUp;
    public GameObject clipboardDown;
    public GameObject questionPage;
    
    //Adam
    [Header("Adam Dialog")]
    public GameObject checkedFileDialogue;
    public GameObject adamTreatmentResponse;
    public GameObject checkedTreatmentDialogue;
    public GameObject patient1Dialogue1;
    public GameObject patient1Dialogue2;
    public GameObject patient1Dialogue3;
    public GameObject patient1Dialogue4;
    public GameObject patient1Dialogue5;
    public GameObject safeResponseAdam;
    public GameObject unsafeResponseAdam;

    //Fishman
    [Header("Fishman Dialog")]
    public GameObject patient2Dialogue1;
    public GameObject patient2Dialogue2;
    public GameObject patient2Dialogue3;
    public GameObject patient2Dialogue4;
    public GameObject patient2Dialogue5;
    public GameObject safeResponseFish;
    public GameObject unsafeResponseFish;

    //Sea Air
    [Header("Sea Air Dialog")]
    public GameObject patient3Dialogue1;
    public GameObject patient3Dialogue2;
    public GameObject patient3Dialogue3;
    public GameObject patient3Dialogue4;
    public GameObject patient3Dialogue5;
    public GameObject safeResponseSeaAir;
    public GameObject unsafeResponseSeaAir;

    public bool checkedTreatment = false;

    public ControllerForPatienter simonScript;

    public Button checkboardDown_;

    public GameObject xButton;
    public GameObject xButton2;

    public GameObject clipbordXButton;
    public GameObject clipbordXButton2;

    public GameObject nextPageTreat;
    public GameObject treatmenatPage;

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
        xButton.SetActive(false);
        xButton2.SetActive(true);
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
            clipbordXButton.SetActive(false);
            clipbordXButton2.SetActive(true);
            nextPageTreat.SetActive(false);
            treatmenatPage.SetActive(false);
            questionPage.SetActive(true);
        }
    }

    //frågor
    public void questionOne()
    {
        putDownClipboard();
        
        if (simonScript.activePatient == 1)
        {
            patient1Dialogue1.SetActive(true);
        }
        
        if(simonScript.activePatient == 2)
        {
            patient2Dialogue1.SetActive(true);
        }

        if(simonScript.activePatient == 3)
        {
            patient3Dialogue1.SetActive(true);
        }
    }

    public void questionTwo()
    {
        putDownClipboard();

        if (simonScript.activePatient == 1)
        {
            patient1Dialogue2.SetActive(true);
        }

        if (simonScript.activePatient == 2)
        {
            patient2Dialogue2.SetActive(true);
        }

        if(simonScript.activePatient == 3)
        {
            patient3Dialogue2.SetActive(true);
        }
    }

    public void questionThree()
    {
        putDownClipboard();

        if (simonScript.activePatient == 1)
        {
            patient1Dialogue3.SetActive(true);
        }

        if (simonScript.activePatient == 2)
        {
            patient2Dialogue3.SetActive(true);
        }
        
        if (simonScript.activePatient == 3)
        {
            patient3Dialogue3.SetActive(true);
        }
    }

    public void questionFour()
    {
        putDownClipboard();

        if (simonScript.activePatient == 1)
        {
            patient1Dialogue4.SetActive(true);
        }

        if (simonScript.activePatient == 2)
        {
            patient2Dialogue4.SetActive(true);
        }

        if (simonScript.activePatient == 3)
        {
            patient3Dialogue4.SetActive(true);
        }
    }

    public void questionFive()
    {
        putDownClipboard();
        
        if (simonScript.activePatient == 1)
        {
            patient1Dialogue5.SetActive(true);
        }

        if (simonScript.activePatient == 2)
        {
            patient2Dialogue5.SetActive(true);
        }

        if (simonScript.activePatient == 3)
        {
            patient3Dialogue5.SetActive(true);
        }
    }

    public void safeRespond()
    {
        if(simonScript.activePatient == 1)
        {
            safeResponseAdam.SetActive(true);
            nextPageTreat.SetActive(true);
        }
        if(simonScript.activePatient == 2)
        {
            safeResponseFish.SetActive(true);
        }

        if (simonScript.activePatient == 3)
        {
            safeResponseSeaAir.SetActive(true);
        }
    }

    public void unsafeRespond()
    {
        if (simonScript.activePatient == 1)
        {
            unsafeResponseAdam.SetActive(true);
            putDownClipboard();
        }
        if(simonScript.activePatient >= 2)
        {
            nextPageTreat.SetActive(true);
        }
    }

    public void treatmentRespond()
    {
        if(simonScript.activePatient == 2)
        {
            unsafeResponseFish.SetActive(true);
        }
        if (simonScript.activePatient == 3)
        {
            unsafeResponseSeaAir.SetActive(true);
        }
        if (simonScript.activePatient >= 2)
        {
            nextPageTreat.SetActive(false);
            treatmenatPage.SetActive(false);
        }
    }
}
