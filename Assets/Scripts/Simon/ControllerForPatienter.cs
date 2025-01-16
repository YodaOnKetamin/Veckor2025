using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControllerForPatienter : MonoBehaviour
{
    PatientMovement PM;

    [SerializeField]
    GameObject adam1;
    [SerializeField]
    GameObject fishMan2;//5
    [SerializeField]
    GameObject seaAir3;//4
    [SerializeField]
    GameObject govermentAgent4;
    [SerializeField]
    GameObject years5;//4
    [SerializeField]
    GameObject workingWoman6;//4
    [SerializeField]
    GameObject priest7;//3
    [SerializeField]
    GameObject artist8;//4
    [SerializeField]
    GameObject where9;//5
    public int day;
    [SerializeField]
    int numberSpawend;

    public bool startDay;
    public int activePatient;

    public bool patientDespawned;
    public bool klarmedpatient;

    GameObject test;

    [SerializeField]
    GameObject BlackScreen;
    public TextMeshProUGUI textComponent;
    string[] line;

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
            StartCoroutine(startNextDay());
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
            StartCoroutine(startNextDay());
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
            StartCoroutine(startNextDay());
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
            else
            {
                activePatient = 8;
                PM = artist8.GetComponent<PatientMovement>();
                PM.startMoving = true;
                numberSpawend++;
            }
        }
        else if (numberSpawend == 1)
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
                PM = priest7.GetComponent<PatientMovement>();
                if (PM.released == false)
                {
                    activePatient = 7;

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
                        numberSpawend++;
                    }
                }
            }
           
        }
        else if (numberSpawend == 2)
        {
            PM = years5.GetComponent<PatientMovement>();
            if (PM.released == false)
            {
                activePatient = 5;
                PM.startMoving = true;
            }
            startDay = false;
            numberSpawend = 0;
            StartCoroutine(startNextDay());
        }
       
    }
    void day5spawns()
    {
        if (numberSpawend == 0)
        {
            PM = artist8.GetComponent<PatientMovement>();
            if (PM.released == false)
            {
                activePatient = 8;
                PM.startMoving = true;
                numberSpawend++;
            }
            else
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
                    numberSpawend++;
                }
            }
        }
        else if (numberSpawend == 1)
        {
            PM = where9.GetComponent<PatientMovement>();
            if (PM.released == false)
            {
                activePatient = 9;
                PM.startMoving = true;
                startDay = false;
            }
            else
            {
                PM = priest7.GetComponent<PatientMovement>();
                if (PM.released == false)
                {
                    activePatient = 7;
                    PM.startMoving = true;
                    startDay = false;
                }
                else
                {
                    startDay = false;
                }
            }
           
        }

       
    }

    IEnumerator startNextDay() 
    {
        textComponent.text = string.Empty;
        line[1] = "End Of day " + day;
        BlackScreen.SetActive(true);
        foreach (char c in line[1].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(3);
        BlackScreen.SetActive(false);
        day++;
        startDay = true;


    }
   
}
