using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControllerForPatienter : MonoBehaviour
{
    PatientMovement PM;
    PatientMovement1 PM1;
    EndingManager EM;
    [SerializeField]
    GameObject EndingManager;

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


    [SerializeField]
    GameObject BlackScreen;
    public TextMeshProUGUI textComponent;

    // Start is called before the first frame update
    void Start()
    {
        EM = EndingManager.GetComponent<EndingManager>();
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

        if (startDay == false && patientDespawned == true)
        {
            StartCoroutine("startNextDay");
            day++;
            startDay = true;
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
                PM1 = workingWoman6.GetComponent<PatientMovement1>();
                PM1.startMoving = true;
                numberSpawend++;
            }
        }
        else if (numberSpawend == 1)
        {
                activePatient = 7;
                PM = priest7.GetComponent<PatientMovement>();
                PM.startMoving = true;
                numberSpawend++;
        }
        else if (numberSpawend == 2)
        {
            activePatient = 5;
            PM1 = years5.GetComponent<PatientMovement1>();
            PM1.startMoving = true;
            startDay = false;
            numberSpawend = 0;
           
        }
    }
    void day3spawns()
    {
        if (numberSpawend == 0)
        {
            PM1 = workingWoman6.GetComponent<PatientMovement1>();
            if (PM1.released == false)
            {
                activePatient = 6;
                PM1.startMoving = true;
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
                    PM1 = where9.GetComponent<PatientMovement1>();
                    PM1.startMoving = true;
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
            PM1 = where9.GetComponent<PatientMovement1>();
            if (PM1.released == false)
            {
                activePatient = 9;
                PM1.startMoving = true;
            }
            else
            {
                PM = seaAir3.GetComponent<PatientMovement>();
                if (PM.released == false)
                {
                    activePatient = 3;
                    PM.startMoving = true;
                }
                else
                {
                    activePatient = 5;
                    PM1 = years5.GetComponent<PatientMovement1>();
                    PM1.startMoving = true;
                }
            }
            startDay = false;
            numberSpawend = 0;
            
        }
      
    }
    void day4spawns()
    {
        if (numberSpawend == 0)
        {
            PM1 = where9.GetComponent<PatientMovement1>();
            if (PM1.released == false)
            {
                PM1.startMoving = true;
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
            PM1 = workingWoman6.GetComponent<PatientMovement1>();
            if (PM1.released == false)
            {
                activePatient = 6;
                PM1.startMoving = true;
                startDay = false;
                numberSpawend = 0;
            }
            else
            {
                PM = seaAir3.GetComponent<PatientMovement>();
                if (PM.released == false)
                {
                    activePatient = 3;

                    PM.startMoving = true;
                    startDay = false;
                    numberSpawend = 0;
                }
                else
                {
                    PM = fishMan2.GetComponent<PatientMovement>();
                    if (PM.released == false)
                    {
                        activePatient = 2;
                        PM.startMoving = true;
                        startDay = false;
                        numberSpawend = 0;
                    }
                    else
                    {
                        PM1 = years5.GetComponent<PatientMovement1>();
                        if (PM1.released == false)
                        {
                            activePatient = 5;
                            PM1.startMoving = true;
                        }
                        startDay = false;
                        numberSpawend = 0;
                    }
                }
            }
           
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
                    EM.endGame = true;
                    startDay = false;
                }
            }
           
        }

       
    }

    IEnumerator startNextDay() 
    {
        textComponent.text = "End Of Day " + day.ToString();
        BlackScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        BlackScreen.SetActive(false);
        //öka sanity med 

    }
   
}
