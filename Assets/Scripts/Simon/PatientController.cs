using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientController : MonoBehaviour
{
    public int day;//5 dagar totalt

    [SerializeField]
    GameObject patient1;
    [SerializeField]
    GameObject patient2;
    [SerializeField]
    GameObject patient3;
    [SerializeField]
    GameObject patient4;
    [SerializeField]
    GameObject Spawn;

    bool hasSpawned1;
    bool hasSpawned2;
    bool hasSpawned3;
    bool newvalue;

    bool tuturialspawned;
    bool firstspawndone;
    bool secondspawndone;

    public bool klarmedpatient;

    float randvalue;
    // Start is called before the first frame update
    void Start()
    {
        day = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (day == 1)
        {
            if (tuturialspawned == false)
            {
                Instantiate(patient1, Spawn.transform.position, Quaternion.identity);
                tuturialspawned = true;
            }
            if (klarmedpatient == true && firstspawndone == false)
            {
                randvalue = Random.Range(2, 5);
                StartCoroutine("SpawnNewPatient");
                klarmedpatient = false;
                firstspawndone = true;
            }
            if (klarmedpatient == true && firstspawndone == true)
            {
                randvalue = Random.Range(2, 5);
                StartCoroutine("SpawnNewPatient");
                klarmedpatient = false;
                secondspawndone = true;
            }
            if (klarmedpatient == true && secondspawndone == true)
            {
                randvalue = Random.Range(2, 5);
                StartCoroutine("SpawnNewPatient");
                klarmedpatient = false;
                secondspawndone = false;
            }
        }
        else if (day == 2)
        {

        }
        else if (day == 3)
        {

        }

        if (newvalue == true)
        {
            randvalue = Random.Range(2, 5);
            StartCoroutine("SpawnNewPatient");
            newvalue = false;
        }
    }

    IEnumerator SpawnNewPatient() 
    {
        yield return new WaitForSeconds(5);
        if (randvalue ==2 && hasSpawned1 == false)
        {
            Instantiate(patient2, Spawn.transform.position, Quaternion.identity);
            hasSpawned1 = true;
        }
        else
        {
            newvalue = true;
        }
        if (randvalue == 3 && hasSpawned2 == false)
        {
            Instantiate(patient3, Spawn.transform.position, Quaternion.identity);
            hasSpawned2 = true;
        }
        else
        {
            newvalue = true;
        }
        if (randvalue == 4 && hasSpawned3 == false)
        {
            Instantiate(patient4, Spawn.transform.position, Quaternion.identity);
            hasSpawned3 = true;
        }
        else
        {
            newvalue = true;
        }
    }
}
