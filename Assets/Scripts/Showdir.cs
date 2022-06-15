using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showdir : MonoBehaviour
{
    GameObject pl;
    void Start()
    {
        pl = GameObject.Find("Playercam");
    }
    void Update()
    {
        this.transform.localRotation = pl.transform.localRotation;
    }
}
