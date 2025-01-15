using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knappen : MonoBehaviour
{
    [SerializeField]
    float tidförknapp;
    [SerializeField]
    GameObject knappen;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(knapptid());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator knapptid()
    {
        yield return new WaitForSeconds(tidförknapp);
        knappen.SetActive(true);
    }
}

