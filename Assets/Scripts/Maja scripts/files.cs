using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class files : MonoBehaviour
{
    public ControllerForPatienter simonScriptYAY;

    public GameObject adamFilesYAY;
    public GameObject fishFilesYAY;
    public GameObject seaAirFilesYAY;
    public GameObject govAgentFilesYAY;
    public GameObject TRETTIyrsFilesYAY;
    public GameObject workWomanFilesYAY;
    public GameObject priestFilesYAY;
    public GameObject artistFilesYAY;
    public GameObject whereAmIFilesYAY;


    public void filesYAY()
    {
        if(simonScriptYAY.activePatient == 1)
        {
            adamFilesYAY.SetActive(true);
        }
        if(simonScriptYAY.activePatient == 2)
        {
            fishFilesYAY.SetActive(true);
            adamFilesYAY.SetActive(false);
        }
        if(simonScriptYAY.activePatient == 3)
        {
            seaAirFilesYAY.SetActive(true);
            fishFilesYAY.SetActive(false);
            adamFilesYAY.SetActive(false);
        }
        if(simonScriptYAY.activePatient == 4)
        {
            govAgentFilesYAY.SetActive(true);
            seaAirFilesYAY.SetActive(false);
            fishFilesYAY.SetActive(false);
            adamFilesYAY.SetActive(false);
        }
        if(simonScriptYAY.activePatient == 5)
        {
            TRETTIyrsFilesYAY.SetActive(true);
            govAgentFilesYAY.SetActive(false);
            seaAirFilesYAY.SetActive(false);
            fishFilesYAY.SetActive(false);
            adamFilesYAY.SetActive(false);
        }
        if(simonScriptYAY.activePatient == 6)
        {
            workWomanFilesYAY.SetActive(true);
            TRETTIyrsFilesYAY.SetActive(false);
            govAgentFilesYAY.SetActive(false);
            seaAirFilesYAY.SetActive(false);
            fishFilesYAY.SetActive(false);
            adamFilesYAY.SetActive(false);
        }
        if(simonScriptYAY.activePatient == 7)
        {
            priestFilesYAY.SetActive(true);
            workWomanFilesYAY.SetActive(false);
            TRETTIyrsFilesYAY.SetActive(false);
            govAgentFilesYAY.SetActive(false);
            seaAirFilesYAY.SetActive(false);
            fishFilesYAY.SetActive(false);
            adamFilesYAY.SetActive(false);
        }
        if(simonScriptYAY.activePatient == 8)
        {
            artistFilesYAY.SetActive(true);
            priestFilesYAY.SetActive(false);
            workWomanFilesYAY.SetActive(false);
            TRETTIyrsFilesYAY.SetActive(false);
            govAgentFilesYAY.SetActive(false);
            seaAirFilesYAY.SetActive(false);
            fishFilesYAY.SetActive(false);
            adamFilesYAY.SetActive(false);
        }
        if(simonScriptYAY.activePatient == 9)
        {
            whereAmIFilesYAY.SetActive(true);
            artistFilesYAY.SetActive(false);
            priestFilesYAY.SetActive(false);
            workWomanFilesYAY.SetActive(false);
            TRETTIyrsFilesYAY.SetActive(false);
            govAgentFilesYAY.SetActive(false);
            seaAirFilesYAY.SetActive(false);
            fishFilesYAY.SetActive(false);
            adamFilesYAY.SetActive(false);
        }
    }
}
