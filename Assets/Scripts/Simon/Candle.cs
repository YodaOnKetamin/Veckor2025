using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    [SerializeField]
    GameObject CandleFull;
    [SerializeField]
    GameObject Candle45;
    [SerializeField]
    GameObject Candle35;
    [SerializeField]
    GameObject Candle25;
    [SerializeField]
    GameObject Candle15;

    public EndingManager EM;
  

    // Start is called before the first frame update
    void Start()
    {
       
        Candle45.SetActive(false);
        Candle35.SetActive(false);
        Candle25.SetActive(false);
        Candle15.SetActive(false);
    }

    // Update is called once per frame 
    void Update()
    {
        if (EM.Sanity == 0)
        {
            CandleFull.SetActive(true);
        }
        else if (EM.Sanity == 1)
        {
            CandleFull.SetActive(false);
            Candle45.SetActive(true);
        }
        else if (EM.Sanity == 2)
        {
            Candle45.SetActive(false);
            Candle35.SetActive(true);
        }
        else if (EM.Sanity == 3)
        {
            Candle35.SetActive(false);
            Candle25.SetActive(true);
        }
        else if (EM.Sanity == 4)
        {
            Candle25.SetActive(false);
            Candle15.SetActive(true);
        }
        else if (EM.Sanity == 5)
        {
            CandleFull.SetActive(false);
            Candle45.SetActive(false);
            Candle35.SetActive(false);
            Candle25.SetActive(false);
            Candle15.SetActive(false);
        }
       
    }
}
