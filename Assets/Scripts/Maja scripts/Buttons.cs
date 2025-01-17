using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject clipboardUp;
    public GameObject clipboardUpGrafik;
    public GameObject clipboardDown;
    public GameObject clipboardDownGrafik;
    public GameObject questionPage;
    
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

    [Header("Fishman Dialog")]
    public GameObject patient2Dialogue1;
    public GameObject patient2Dialogue2;
    public GameObject patient2Dialogue3;
    public GameObject patient2Dialogue4;
    public GameObject patient2Dialogue5;
    public GameObject safeResponseFish;
    public GameObject unsafeResponseFish;

    [Header("Sea Air Dialog")]
    public GameObject patient3Dialogue1;
    public GameObject patient3Dialogue2;
    public GameObject patient3Dialogue3;
    public GameObject patient3Dialogue4;
    public GameObject patient3Dialogue5;
    public GameObject safeResponseSeaAir;
    public GameObject unsafeResponseSeaAir;

    [Header("Goverment Agent Dialog")]
    public GameObject patient4Dialogue1;
    public GameObject patient4Dialogue2;
    public GameObject patient4Dialogue3;
    public GameObject patient4Dialogue4;
    public GameObject patient4Dialogue5;
    public GameObject safeResponseGov;
    public GameObject unsafeResponseGov;

    [Header("30 Years Dialog")]
    public GameObject patient5Dialogue1;
    public GameObject patient5Dialogue2;
    public GameObject patient5Dialogue3;
    public GameObject patient5Dialogue4;
    public GameObject patient5Dialogue5;
    public GameObject safeResponse30;
    public GameObject unsafeResponse30;

    [Header("Working Class Woman Dialog")]
    public GameObject patient6Dialogue1;
    public GameObject patient6Dialogue2;
    public GameObject patient6Dialogue3;
    public GameObject patient6Dialogue4;
    public GameObject patient6Dialogue5;
    public GameObject safeResponseWoman;
    public GameObject unsafeResponseWoman;

    [Header("Priest Dialog")]
    public GameObject patient7Dialogue1;
    public GameObject patient7Dialogue2;
    public GameObject patient7Dialogue3;
    public GameObject patient7Dialogue4;
    public GameObject patient7Dialogue5;
    public GameObject safeResponsePriest;
    public GameObject unsafeResponsePriest;

    [Header("Artist dialog")]
    public GameObject patient8Dialogue1;
    public GameObject patient8Dialogue2;
    public GameObject patient8Dialogue3;
    public GameObject patient8Dialogue4;
    public GameObject patient8Dialogue5;
    public GameObject safeResponseArtist;
    public GameObject unsafeResponseArtist;

    [Header("Where Am I Dialog")]
    public GameObject patient9Dialogue1;
    public GameObject patient9Dialogue2;
    public GameObject patient9Dialogue3;
    public GameObject patient9Dialogue4;
    public GameObject patient9Dialogue5;
    public GameObject safeResponseWhere;
    public GameObject unsafeResponseWhere;

    [Header("Sea Air Treated")]
    public GameObject seaAirTreatD1;
    public GameObject seaAirTreatD2;
    public GameObject seaAirTreatD3;
    public GameObject seaAirTreatD4;
    public GameObject seaAirTreatD5;
    public GameObject safeResponseSeaTreat;
    public GameObject unsafeResponseSeaTreat;

    [Header("30 years confinement")]
    public GameObject yearsConfinementD1;
    public GameObject yearsConfinementD2;
    public GameObject yearsConfinementD3;
    public GameObject yearsConfinementD4;
    public GameObject yearsConfinementD5;
    public GameObject safeResponseYearsCon;
    public GameObject unsafeResponseYearsCon;

    [Header("Working Class Woman Electro")]
    public GameObject womanElectroD1;
    public GameObject womanElectroD2;
    public GameObject womanElectroD3;
    public GameObject womanElectroD4;
    public GameObject womanElectroD5;
    public GameObject safeResponseWomanElec;
    public GameObject unsafeResponseWomanElec;

    [Header("Where Am I Electro")]
    public GameObject whereElectroD1;
    public GameObject whereElectroD2;
    public GameObject whereElectroD3;
    public GameObject whereElectroD4;
    public GameObject whereElectroD5;
    public GameObject safeResponseWhereElec;
    public GameObject unsafeResponseWhereElec;

    [Header("Lobotomy")]
    public GameObject lobotomyD1;
    public GameObject lobotomyD2;
    public GameObject lobotomyD3;
    public GameObject lobotomyD4;
    public GameObject lobotomyD5;
    public GameObject safeResponseLobo;
    public GameObject unsafeResponseLobo;

    [Header("extra")]
    public bool checkedTreatment = false;

    public ControllerForPatienter simonScript;
    public PatientMovement simonScript2;

    public Button checkboardDown_;

    public GameObject xButton;
    public GameObject xButton2;

    public GameObject clipbordXButton;
    public GameObject clipbordXButton2;

    public GameObject nextPageTreat;
    public GameObject treatmenatPage;
    GameObject patient;

    private void Start()
    {
        checkboardDown_.enabled = false;
    }

    public void Clipboard()
    {
        clipboardUp.SetActive(true);
        clipboardUpGrafik.SetActive(true);
        clipboardDown.SetActive(false);
        clipboardDownGrafik.SetActive(false);
    }

    public void putDownClipboard()
    {
        clipboardUp.SetActive(false);
        clipboardUpGrafik.SetActive(false);
        clipboardDown.SetActive(true);
        clipboardDownGrafik.SetActive(true);
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

    public void adamTreatment()
    {
        if(simonScript.activePatient != 1)
        {
            putDownClipboard();
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
            patient = GameObject.FindWithTag("Patient3");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient3Dialogue1.SetActive(true);
            }
            else if(simonScript2.correctlyTreated == true)
            {
                seaAirTreatD1.SetActive(true);
            }
        }
        if(simonScript.activePatient == 4)
        {
            patient4Dialogue1.SetActive(true);
        }
        if(simonScript.activePatient == 5)
        {
            
            patient = GameObject.FindWithTag("Patient5");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == true)
            {
                patient5Dialogue1.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                yearsConfinementD1.SetActive(true);
            }
        }
        if(simonScript.activePatient == 6)
        {
            patient = GameObject.FindWithTag("Patient6");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient6Dialogue1.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                womanElectroD1.SetActive(true);
            }
        }
        if(simonScript.activePatient == 7)
        {
            patient7Dialogue1.SetActive(true);
        }
        if(simonScript.activePatient == 8)
        {
            patient8Dialogue1.SetActive(true);
        }
        if(simonScript.activePatient == 9)
        {         
            patient = GameObject.FindWithTag("Patient9");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient9Dialogue1.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                whereElectroD1.SetActive(true);
            }
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
            patient = GameObject.FindWithTag("Patient3");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient3Dialogue2.SetActive(true);
            }
            else if(simonScript2.correctlyTreated == true)
            {
                seaAirTreatD2.SetActive(true);
            }
        }
        if (simonScript.activePatient == 4)
        {
            patient4Dialogue2.SetActive(true);
        }
        if (simonScript.activePatient == 5)
        {
            patient = GameObject.FindWithTag("Patient5");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient5Dialogue2.SetActive(true);
            }
            else if(simonScript2.correctlyTreated == true)
            {
                yearsConfinementD2.SetActive(true);
            }
        }
        if (simonScript.activePatient == 6)
        {
            patient = GameObject.FindWithTag("Patient6");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient6Dialogue2.SetActive(true);
            }
            else if(simonScript2.correctlyTreated == true)
            {
                womanElectroD2.SetActive(true);
            }
        }
        if (simonScript.activePatient == 7)
        {
            patient7Dialogue2.SetActive(true);
        }
        if (simonScript.activePatient == 8)
        {
            patient8Dialogue2.SetActive(true);
        }
        if (simonScript.activePatient == 9)
        {
            patient = GameObject.FindWithTag("Patient9");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient9Dialogue2.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                whereElectroD2.SetActive(true);
            }
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
            patient = GameObject.FindWithTag("Patient3");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient3Dialogue3.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                seaAirTreatD3.SetActive(true);
            }
        }
        if (simonScript.activePatient == 4)
        {
            patient4Dialogue3.SetActive(true);
        }
        if (simonScript.activePatient == 5)
        {
            patient = GameObject.FindWithTag("Patient5");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient5Dialogue3.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                yearsConfinementD3.SetActive(true);
            }
        }
        if (simonScript.activePatient == 6)
        {
            patient = GameObject.FindWithTag("Patient6");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient6Dialogue3.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                womanElectroD3.SetActive(true);
            }
        }
        if (simonScript.activePatient == 7)
        {
            patient7Dialogue3.SetActive(true);
        }
        if (simonScript.activePatient == 8)
        {
            patient8Dialogue3.SetActive(true);
        }
        if (simonScript.activePatient == 9)
        {
            patient = GameObject.FindWithTag("Patient9");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient9Dialogue3.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                whereElectroD3.SetActive(true);
            }
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
            patient = GameObject.FindWithTag("Patient3");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient3Dialogue4.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                seaAirTreatD4.SetActive(true);
            }
        }
        if (simonScript.activePatient == 4)
        {
            patient4Dialogue4.SetActive(true);
        }
        if (simonScript.activePatient == 5)
        {
            patient = GameObject.FindWithTag("Patient5");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient5Dialogue4.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                yearsConfinementD4.SetActive(true);
            }
        }
        if (simonScript.activePatient == 6)
        {
            patient = GameObject.FindWithTag("Patient6");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient6Dialogue4.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                womanElectroD4.SetActive(true);
            }
        }
        if (simonScript.activePatient == 7)
        {
            patient7Dialogue4.SetActive(true);
        }
        if (simonScript.activePatient == 8)
        {
            patient8Dialogue4.SetActive(true);
        }
        if (simonScript.activePatient == 9)
        {
            patient = GameObject.FindWithTag("Patient9");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient9Dialogue4.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                whereElectroD4.SetActive(true);
            }
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
            patient = GameObject.FindWithTag("Patient3");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient3Dialogue5.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                seaAirTreatD5.SetActive(true);
            }
        }
        if (simonScript.activePatient == 4)
        {
            patient4Dialogue5.SetActive(true);
        }
        if (simonScript.activePatient == 5)
        {
            patient = GameObject.FindWithTag("Patient5");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient5Dialogue5.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                yearsConfinementD5.SetActive(true);
            }
        }
        if (simonScript.activePatient == 6)
        {
            patient = GameObject.FindWithTag("Patient6");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient6Dialogue5.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                womanElectroD5.SetActive(true);
            }
        }
        if (simonScript.activePatient == 7)
        {
            patient7Dialogue5.SetActive(true);
        }       
        if (simonScript.activePatient == 8)
        {
            patient8Dialogue5.SetActive(true);
        }
        if (simonScript.activePatient == 9)
        {
            patient = GameObject.FindWithTag("Patient9");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                patient9Dialogue5.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                whereElectroD5.SetActive(true);
            }
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
            patient = GameObject.FindWithTag("Patient3");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                safeResponseSeaAir.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                safeResponseSeaTreat.SetActive(true);
            }
        }
        if (simonScript.activePatient == 4)
        {
            safeResponseGov.SetActive(true);
        }
        if (simonScript.activePatient == 5)
        {
            patient = GameObject.FindWithTag("Patient5");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                safeResponse30.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                safeResponseYearsCon.SetActive(true);
            }
        }
        if (simonScript.activePatient == 6)
        {
            patient = GameObject.FindWithTag("Patient6");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                safeResponseWoman.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                safeResponseWomanElec.SetActive(true);
            }
        }
        if (simonScript.activePatient == 7)
        {
            safeResponsePriest.SetActive(true);
        }
        if (simonScript.activePatient == 8)
        {
            safeResponseArtist.SetActive(true);
        }
        if (simonScript.activePatient == 9)
        {
            patient = GameObject.FindWithTag("Patient9");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                safeResponseWhere.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                safeResponseWhereElec.SetActive(true);
            }
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
        if (simonScript.activePatient >= 2)
        {
            nextPageTreat.SetActive(false);
            treatmenatPage.SetActive(false);
            questionPage.SetActive(true);
        }

        if (simonScript.activePatient == 2)
        {
            unsafeResponseFish.SetActive(true);
        }
        if (simonScript.activePatient == 3)
        {
            patient = GameObject.FindWithTag("Patient3");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                unsafeResponseSeaAir.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                unsafeResponseSeaTreat.SetActive(true);
            }
        }
        if (simonScript.activePatient == 4)
        {
            unsafeResponseGov.SetActive(true);
        }
        if (simonScript.activePatient == 5)
        {
            patient = GameObject.FindWithTag("Patient5");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                unsafeResponse30.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                unsafeResponseYearsCon.SetActive(true);
            }
        }
        if (simonScript.activePatient == 6)
        {
            patient = GameObject.FindWithTag("Patient6");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                unsafeResponseWoman.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                unsafeResponseWomanElec.SetActive(true);
            }
        }
        if (simonScript.activePatient == 7)
        {
            unsafeResponsePriest.SetActive(true);
        }
        if (simonScript.activePatient == 8)
        {
            unsafeResponseArtist.SetActive(true);
        }
        if (simonScript.activePatient == 9)
        {
            patient = GameObject.FindWithTag("Patient9");
            simonScript2 = patient.GetComponent<PatientMovement>();
            if (simonScript2.correctlyTreated == false)
            {
                unsafeResponseWhere.SetActive(true);
            }
            else if (simonScript2.correctlyTreated == true)
            {
                unsafeResponseWhereElec.SetActive(true);
            }
        }
    }
}
