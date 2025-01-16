using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientMovement : MonoBehaviour
{
    [SerializeField]
    GameObject Dialouge;
    [SerializeField]
    GameObject LoboDialouge;
    [SerializeField]
    int vänsterkraft;
    [SerializeField]
    GameObject Spawn;
    GameObject Controler;
    ControllerForPatienter PC;

    bool dialogueHasStarted;
   public bool lobotmised;
   public bool correctlyTreated;
   public bool released;

    public bool startMoving;
  
    // Start is called before the first frame update
    void Start()
    {
        Controler = GameObject.FindWithTag("Controller");
        PC = Controler.GetComponent<ControllerForPatienter>();
        dialogueHasStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueHasStarted == false && gameObject.transform.position.x == 0)
        {
            if (gameObject.transform.position.x == 0 && lobotmised == false)
            {
                print("show dialogue");
                Dialouge.SetActive(true);
                dialogueHasStarted = true;
            }
            else if (lobotmised == true)
            {
                LoboDialouge.SetActive(true);
                dialogueHasStarted = true;
            }
            
        }
       

        if (startMoving == true)
        {
            if (gameObject.transform.position.x <= 0)
            {
                transform.position += new Vector3(vänsterkraft, 0, 0) * Time.deltaTime;
            }

            if (PC.klarmedpatient == false && gameObject.transform.position.x > 0)
            {
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
            }

          

            if (PC.klarmedpatient == true)
            {
                transform.position += new Vector3(vänsterkraft, 0, 0) * Time.deltaTime;
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
