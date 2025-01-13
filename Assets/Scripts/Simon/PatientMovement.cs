using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientMovement : MonoBehaviour
{
    [SerializeField]
    GameObject Dialouge;
    [SerializeField]
    int v�nsterkraft;
    [SerializeField]
    GameObject Spawn;
    GameObject Controler;
    ControllerForPatienter PC;

    bool lobotmised;
    bool correctlyTreated;

    public bool startMoving;
  
    // Start is called before the first frame update
    void Start()
    {
        Controler = GameObject.FindWithTag("Controller");
        PC = Controler.GetComponent<ControllerForPatienter>();
        
    }

    // Update is called once per frame
    void Update()
    {


        if (startMoving == true)
        {
            if (gameObject.transform.position.x <= 0)
            {
                transform.position += new Vector3(v�nsterkraft, 0, 0) * Time.deltaTime;
            }

            if (gameObject.transform.position.x == 0)
            {
                Dialouge.SetActive(true);
            }

            if (PC.klarmedpatient == true)
            {
                transform.position += new Vector3(v�nsterkraft, 0, 0) * Time.deltaTime;
            }

            if (gameObject.transform.position.x >= 7)
            {
                PC.patientDespawned = true;
                PC.klarmedpatient = false;
                startMoving = false;
                gameObject.transform.position = Spawn.transform.position;
            }
        }
       
    }
}
