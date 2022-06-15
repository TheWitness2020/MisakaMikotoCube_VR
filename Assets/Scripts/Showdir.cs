using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameCore_Data;
public class Showdir : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        if (locked == 0 || locked == 1)
        {
            this.transform.rotation = pl.transform.rotation;
        }
    }
}
