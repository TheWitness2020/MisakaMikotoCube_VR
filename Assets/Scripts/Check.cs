using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameCore_Data;

public class Check : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter()
    {
        pl.GetComponent<Camera>().enabled = false;
        tx.SetActive(true);
    }
}
