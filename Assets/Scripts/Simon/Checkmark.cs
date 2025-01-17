using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkmark : MonoBehaviour
{
    [SerializeField]
    Toggle Q1Yes;
    [SerializeField]
    Toggle Q1No;
    [SerializeField]
    Toggle Q2Self;
    [SerializeField]
    Toggle Q2Other;
    [SerializeField]
    Toggle Q2Out;
    [SerializeField]
    Toggle Q3Yes;
    [SerializeField]
    Toggle Q3No;
    [SerializeField]
    Toggle Q4Yes;
    [SerializeField]
    Toggle Q4No;
    [SerializeField]
    Toggle Q5Yes;
    [SerializeField]
    Toggle Q5No;
   
   
    ControllerForPatienter PC;
    GameObject Controler;

    // Start is called before the first frame update
    void Start()
    {
        Controler = GameObject.FindWithTag("Controller");
        PC = Controler.GetComponent<ControllerForPatienter>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PC.klarmedpatient == true)
        {
            Q1No.isOn = false;
            Q1Yes.isOn = false;
            Q2Self.isOn = false;
            Q2Out.isOn = false;
            Q2Other.isOn = false;
            Q3Yes.isOn = false;
            Q3No.isOn = false;
            Q4Yes.isOn = false;
            Q4No.isOn = false;
            Q5No.isOn = false;
            Q5Yes.isOn = false;
        }
    }
}
