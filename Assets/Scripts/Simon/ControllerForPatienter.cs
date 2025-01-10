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
    int day;
    int numberSpawend;
    
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
    }

    // Update is called once per frame
    void Update()
    {
        if (day == 1 && patientDespawned == true)
        {
            day1spawns();
            patientDespawned = false;
        }

        if (newvalue == true)
        {
            randvalue = Random.Range(2, 5);
            StartCoroutine("SpawnNewPatient");
            newvalue = false;
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
            randvalue = Random.Range(2, 5);
            StartCoroutine("SpawnNewPatient");
            numberSpawend++;
        }
        else if (numberSpawend == 2)
        {
            randvalue = Random.Range(2, 5);
            StartCoroutine("SpawnNewPatient");
            numberSpawend++;
        }
        else if (numberSpawend == 3)
        {
            randvalue = Random.Range(2, 5);
            StartCoroutine("SpawnNewPatient");
            numberSpawend++;
        }
    }

    IEnumerator SpawnNewPatient()
    {
        print("spawnNewPatient");
        yield return new WaitForSeconds(5);
        if (randvalue == 2 && hasSpawned1 == false)
        {
            Instantiate(patient2, gameObject.transform.position, Quaternion.identity);
            hasSpawned1 = true;
        }
        else
        {
            newvalue = true;
        }
        if (randvalue == 3 && hasSpawned2 == false)
        {
            Instantiate(patient3, gameObject.transform.position, Quaternion.identity);
            hasSpawned2 = true;
        }
        else
        {
            newvalue = true;
        }
        if (randvalue == 4 && hasSpawned3 == false)
        {
            Instantiate(patient4, gameObject.transform.position, Quaternion.identity);
            hasSpawned3 = true;
        }
        else
        {
            newvalue = true;
        }
    }
}
