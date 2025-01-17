using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treatments : MonoBehaviour
{
    PatientMovement PM;
    PatientMovement1 PM1;
    ControllerForPatienter PC;
    EndingManager EM;
    GameObject Controler;

    [SerializeField]
    GameObject adam1;
    [SerializeField]
    GameObject fishMan2;
    [SerializeField]
    GameObject seaAir3;
    [SerializeField]
    GameObject govermentAgent4;
    [SerializeField]
    GameObject years5;
    [SerializeField]
    GameObject workingWoman6;
    [SerializeField]
    GameObject priest7;//3
    [SerializeField]
    GameObject artist8;//4
    [SerializeField]
    GameObject where9;//5
    // Start is called before the first frame update
    void Start()
    {
        Controler = GameObject.FindWithTag("Controller");
        PC = Controler.GetComponent<ControllerForPatienter>();
        gameObject.GetComponent<EndingManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PC.activePatient == 1)
        {
            PM = adam1.GetComponent<PatientMovement>();
        }
        else if (PC.activePatient == 2)
        {
            PM = fishMan2.GetComponent<PatientMovement>();
        }
        else if (PC.activePatient == 3)
        {
            PM = seaAir3.GetComponent<PatientMovement>();
        }
        else if (PC.activePatient == 4)
        {
            PM = govermentAgent4.GetComponent<PatientMovement>();
        }
        else if (PC.activePatient == 5)
        {
            PM1 = years5.GetComponent<PatientMovement1>();
        }
        else if (PC.activePatient == 6)
        {
            PM1 = workingWoman6.GetComponent<PatientMovement1>();
        }
        else if (PC.activePatient == 7)
        {
            PM = priest7.GetComponent<PatientMovement>();
        }
        else if (PC.activePatient == 8)
        {
            PM = artist8.GetComponent<PatientMovement>();
        }
        else if (PC.activePatient == 9)
        {
            PM1 = where9.GetComponent<PatientMovement1>();
        }
    }

    public void OnPressTreatButtonLobo() 
    {
        PM.lobotmised = true;
        if (PC.activePatient == 2)
        {
            PM.correctlyTreated = true;
        }
        if (PC.activePatient == 3)
        {
            EM.Sanity++;
        }
        if (PC.activePatient == 5)
        {
            EM.Sanity++;
        }

        if (PC.activePatient == 6)
        {
            EM.Sanity++;
        }

        if (PC.activePatient == 8)
        {
            PM.lobotmised = true;
        }

        if (PC.activePatient == 9)
        {
            EM.Sanity++;
        }

        if (PC.activePatient == 4)
        {
            EM.Warnings++;
        }

    }
    public void OnPressTreatButtonElectro()
    {
        if (PC.activePatient == 2)
        {
            EM.lightTreatemnts++;
            
        }
        if (PC.activePatient == 3)
        {
            EM.Sanity++;
            
        }
        if (PC.activePatient == 5)
        {
            EM.Sanity++;
            
        }

        if (PC.activePatient == 6)
        {
            PM1.correctlyTreated = true;
            
        }

        if (PC.activePatient == 8)
        {
            EM.lightTreatemnts++;
        }

        if (PC.activePatient == 9)
        {
            PM1.correctlyTreated = true;
        }
        if (PC.activePatient == 4)
        {
            EM.Warnings++;
        }
    }
    public void OnPressTreatButtonSoli()
    {
        if (PC.activePatient == 2)
        {
            EM.lightTreatemnts++;
        }
        if (PC.activePatient == 3)
        {
            EM.Sanity++;
        }
        if (PC.activePatient == 5)
        {
            PM1.correctlyTreated = true;
        }

        if (PC.activePatient == 6)
        {
            EM.lightTreatemnts++;
        }
        if (PC.activePatient == 8)
        {
            EM.lightTreatemnts++;
        }
        if (PC.activePatient == 9)
        {
            EM.lightTreatemnts++;
        }
        if (PC.activePatient == 4)
        {
            EM.Warnings++;
        }
    }

    public void OnPressTreatButtonReEd()
    {
        if (PC.activePatient == 3)
        {
            PM.correctlyTreated = true;
        }

        if (PC.activePatient == 2)
        {
            EM.lightTreatemnts++;
        }
        if (PC.activePatient == 5)
        {
            EM.lightTreatemnts++;
        }

        if (PC.activePatient == 6)
        {
            EM.lightTreatemnts++;
        }
        if (PC.activePatient == 8)
        {
            EM.lightTreatemnts++;
        }
        if (PC.activePatient == 9)
        {
            EM.lightTreatemnts++;
        }
        if (PC.activePatient == 4)
        {
            EM.Warnings++;
        }
    }

    public void OnPressTreatButtonRelease()
    {
        PM.released = true;
    }
}
