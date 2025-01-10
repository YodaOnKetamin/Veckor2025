using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientMovement : MonoBehaviour
{
    [SerializeField]
    int v�nsterkraft;
    GameObject Controler;
    ControllerForPatienter PC;

  
    // Start is called before the first frame update
    void Start()
    {
        Controler = GameObject.FindWithTag("Controller");
        PC = Controler.GetComponent<ControllerForPatienter>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (gameObject.transform.position.x <= 0)
        {
            transform.position += new Vector3(v�nsterkraft,0,0) * Time.deltaTime;
        }
        
        if (PC.klarmedpatient == true)
        {
            transform.position += new Vector3(v�nsterkraft, 0, 0) * Time.deltaTime;
        }

        if (gameObject.transform.position.x >= 7)
        {
            PC.patientDespawned = true;
            PC.klarmedpatient = false;
            Destroy(gameObject);
        }
    }
}
