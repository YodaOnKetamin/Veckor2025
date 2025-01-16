using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treatments : MonoBehaviour
{
    PatientMovement PM;
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
    }

    public void OnPressTreatButtonLobo() 
    {
        PM.lobotmised = true;
        if (PC.activePatient == 2)
        {
            PM.correctlyTreated = true;
        }
       
    }
    public void OnPressTreatButtonElectro()
    {
        if (PC.activePatient == 2)
        {
            EM.lightTreatemnts++;
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

    }

    /*public void OnPressTreatButtonRelease()
    {
        PM.released = true;
        
    }*/
}
