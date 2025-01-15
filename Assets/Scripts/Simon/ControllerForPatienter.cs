using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerForPatienter : MonoBehaviour
{
    PatientMovement PM;

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
    GameObject priest7;
    [SerializeField]
    GameObject artist8;
    [SerializeField]
    GameObject where9;
    public int day;
    [SerializeField]
    int numberSpawend;

    public bool startDay;
    public int activePatient;

    public bool patientDespawned;
    public bool klarmedpatient;
    // Start is called before the first frame update
    void Start()
    {
        patientDespawned = true;
        numberSpawend = 0;
        day = 1;
        startDay = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (startDay == true)
        {
            if (day == 1 && patientDespawned == true)
            {
                day1spawns();
                patientDespawned = false;
            }
            else if (day == 2 && patientDespawned == true)
            {
                day2spawns();
                patientDespawned = false;
            }
            else if (day == 3 && patientDespawned == true)
            {
                day3spawns();
                patientDespawned = false;
            }
            else if (day == 4 && patientDespawned == true)
            {
                day4spawns();
                patientDespawned = false;
            }
            else if (day == 5 && patientDespawned == true)
            {
                day5spawns();
                patientDespawned = false;
            }
        }
    }

    void day1spawns()
    {
        if (numberSpawend == 0)
        {
            activePatient = 1;
            PM = adam1.GetComponent<PatientMovement>();
            PM.startMoving = true;
            numberSpawend++;
        }
        else if (numberSpawend == 1)
        {
            activePatient = 2; 
            PM = fishMan2.GetComponent<PatientMovement>();
            PM.startMoving = true;
            numberSpawend++;
        }
        else if (numberSpawend == 2)
        {
            activePatient = 3;
            PM = seaAir3.GetComponent<PatientMovement>();
            PM.startMoving = true;
            numberSpawend++;
        }
        else if (numberSpawend == 3)
        {
            activePatient = 4;
            PM = govermentAgent4.GetComponent<PatientMovement>();
            PM.startMoving = true;
            startDay = false;
            numberSpawend = 0;
            day = 2;
        }
    }

    void day2spawns()
    {
        if (numberSpawend == 0)
        {
            PM = fishMan2.GetComponent<PatientMovement>();
            if (PM.released == false)
            {
                activePatient = 2;
                PM.startMoving = true;
                numberSpawend++;
            }
            else
            {
                activePatient = 6;
                PM = workingWoman6.GetComponent<PatientMovement>();
                PM.startMoving = true;
                numberSpawend++;
            }
        }
        else if (numberSpawend == 1)
        {
            PM = priest7.GetComponent<PatientMovement>();
                activePatient = 3;
                PM.startMoving = true;
                numberSpawend++;
        }
        else if (numberSpawend == 2)
        {
            PM = years5.GetComponent<PatientMovement>();
            PM.startMoving = true;
            startDay = false;
            numberSpawend = 0;
            day = 3;
        }
    }
    void day3spawns()
    {
        if (numberSpawend == 0)
        {
            PM = workingWoman6.GetComponent<PatientMovement>();
            if (PM.released == false)
            {
                activePatient = 6;
                PM.startMoving = true;
                numberSpawend++;
            }
            else
            {
                PM = fishMan2.GetComponent<PatientMovement>();
                if (PM.released == false)
                {
                    activePatient = 2;
                    PM.startMoving = true;
                    numberSpawend++;
                }
                else
                {
                    activePatient = 9;
                    PM = where9.GetComponent<PatientMovement>();
                    PM.startMoving = true;
                    numberSpawend++;
                }
                
            } 
        }
        else if (numberSpawend == 1)
        {
            PM = seaAir3.GetComponent<PatientMovement>();
            if (PM.released == false)
            {
                activePatient = 3;
                PM.startMoving = true;
                numberSpawend++;
            }
            else
            {
                activePatient = 8;
                PM = artist8.GetComponent<PatientMovement>();
                PM.startMoving = true;
                numberSpawend++;
            }
        }
        else if (numberSpawend == 2)
        {
            PM = priest7.GetComponent<PatientMovement>();
            if (PM.released == false)
            {
                activePatient = 7;
                PM.startMoving = true;
            }
            else
            {
                PM = where9.GetComponent<PatientMovement>();
                if (PM.released == false)
                {
                    activePatient = 9;
                    PM.startMoving = true;
                }
                else
                {
                    activePatient = 5;
                    PM = years5.GetComponent<PatientMovement>();
                    PM.startMoving = true;
                }
            }
            startDay = false;
            numberSpawend = 0;
            day = 4;
        }
      
    }
    void day4spawns()
    {
        if (numberSpawend == 0)
        {
            PM = where9.GetComponent<PatientMovement>();
            if (PM.released == false)
            {
                PM.startMoving = true;
                numberSpawend++;
            }
           
           
        }
        else if (numberSpawend == 1)
        {
            PM = seaAir3.GetComponent<PatientMovement>();
            PM.startMoving = true;
            numberSpawend++;
        }
        else if (numberSpawend == 2)
        {
            PM = govermentAgent4.GetComponent<PatientMovement>();
            PM.startMoving = true;
            startDay = false;
            numberSpawend = 0;
            day = 5;
        }
       
    }
    void day5spawns()
    {
        if (numberSpawend == 0)
        {
            PM = fishMan2.GetComponent<PatientMovement>();
            PM.startMoving = true;
            numberSpawend++;
        }
        else if (numberSpawend == 1)
        {
            PM = seaAir3.GetComponent<PatientMovement>();
            PM.startMoving = true;
            numberSpawend++;
        }
        else if (numberSpawend == 2)
        {
            PM = govermentAgent4.GetComponent<PatientMovement>();
            PM.startMoving = true;
            startDay = false;
        }
     
    }
}
