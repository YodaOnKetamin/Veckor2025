using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treatments : MonoBehaviour
{
    PatientMovement PM;
    ControllerForPatienter PC;
    GameObject Controler;

    [SerializeField]
    GameObject patient1;
    [SerializeField]
    GameObject patient2;
    [SerializeField]
    GameObject patient3;
    [SerializeField]
    GameObject patient4;
    // Start is called before the first frame update
    void Start()
    {
        Controler = GameObject.FindWithTag("Controller");
        PC = Controler.GetComponent<ControllerForPatienter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PC.activePatient == 1)
        {
            PM = patient1.GetComponent<PatientMovement>();
        }
        else if (PC.activePatient == 2)
        {
            PM = patient2.GetComponent<PatientMovement>();
        }
        else if (PC.activePatient == 3)
        {
            PM = patient3.GetComponent<PatientMovement>();
        }
        else if (PC.activePatient == 4)
        {
            PM = patient4.GetComponent<PatientMovement>();
        }
    }

    public void OnPressTreatButtonLobo() 
    {
        PM.lobotmised = true;
        if (PC.activePatient == 2)
        {
            PM.correctlyTreated = true;
        }
        PC.klarmedpatient = true;
    }
    public void OnPressTreatButtonElectro()
    {
        PC.klarmedpatient = true;
    }
    public void OnPressTreatButtonSoli()
    {
        PC.klarmedpatient = true;
    }

    public void OnPressTreatButtonReEd()
    {
        if (PC.activePatient == 3)
        {
            PM.correctlyTreated = true;
        }
        PC.klarmedpatient = true;
    }

    public void OnPressTreatButtonRelease()
    {
        PM.released = true;
        PC.klarmedpatient = true;
    }
}
