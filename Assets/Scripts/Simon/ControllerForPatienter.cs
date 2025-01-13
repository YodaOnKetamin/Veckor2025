using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerForPatienter : MonoBehaviour
{
    [SerializeField]
    GameObject patient1;
    [SerializeField]
    GameObject patient2;
    [SerializeField]
    GameObject patient3;
    [SerializeField]
    GameObject patient4;
    public int day;
    [SerializeField]
    int numberSpawend;

    public bool startDay;

    float randvalue;
    bool hasSpawned1;
    bool hasSpawned2;
    bool hasSpawned3;
    bool newvalue;

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
            Instantiate(patient1, gameObject.transform.position, Quaternion.identity);
            numberSpawend++;
        }
        else if (numberSpawend == 1)
        {
            Instantiate(patient2, gameObject.transform.position, Quaternion.identity);
            numberSpawend++;
        }
        else if (numberSpawend == 2)
        {
            Instantiate(patient3, gameObject.transform.position, Quaternion.identity);
            numberSpawend++;
        }
        else if (numberSpawend == 3)
        {
            Instantiate(patient4, gameObject.transform.position, Quaternion.identity);
            startDay = false;
            numberSpawend = 0;
            day = 2;
        }

        
    }

    void day2spawns()
    {
        if (numberSpawend == 0)
        {
            Instantiate(patient2, gameObject.transform.position, Quaternion.identity);
            numberSpawend++;
        }
        else if (numberSpawend == 1)
        {
            Instantiate(patient3, gameObject.transform.position, Quaternion.identity);
            numberSpawend++;
        }
        else if (numberSpawend == 2)
        {
            Instantiate(patient4, gameObject.transform.position, Quaternion.identity);
            startDay = false;
            numberSpawend = 0;
            day = 3;
        }
      
    }
    void day3spawns()
    {
        if (numberSpawend == 0)
        {
            Instantiate(patient2, gameObject.transform.position, Quaternion.identity);
            numberSpawend++;
        }
        else if (numberSpawend == 1)
        {
            Instantiate(patient3, gameObject.transform.position, Quaternion.identity);
            numberSpawend++;
        }
        else if (numberSpawend == 2)
        {
            Instantiate(patient4, gameObject.transform.position, Quaternion.identity);
            startDay = false;
            numberSpawend = 0;
            day = 4;
        }
      
    }
    void day4spawns()
    {
        if (numberSpawend == 0)
        {
            Instantiate(patient2, gameObject.transform.position, Quaternion.identity);
            numberSpawend++;
        }
        else if (numberSpawend == 1)
        {
            Instantiate(patient3, gameObject.transform.position, Quaternion.identity);
            numberSpawend++;
        }
        else if (numberSpawend == 2)
        {
            Instantiate(patient4, gameObject.transform.position, Quaternion.identity);
            startDay = false;
            numberSpawend = 0;
            day = 5;
        }
       
    }
    void day5spawns()
    {
        if (numberSpawend == 0)
        {
            Instantiate(patient2, gameObject.transform.position, Quaternion.identity);
            numberSpawend++;
        }
        else if (numberSpawend == 1)
        {
            Instantiate(patient3, gameObject.transform.position, Quaternion.identity);
            numberSpawend++;
        }
        else if (numberSpawend == 2)
        {
            Instantiate(patient4, gameObject.transform.position, Quaternion.identity);
            startDay = false;
        }
     
    }
}
