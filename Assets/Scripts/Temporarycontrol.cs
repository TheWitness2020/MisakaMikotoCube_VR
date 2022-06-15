using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameCore_Data;

public class Temporarycontrol : MonoBehaviour
{
    public float dtheta = 0.01f;
    void Start()
    {

    }
    void Update()
    {
        Vector3 zhou;
        Quaternion rot = new Quaternion(0, 0, 0, 1);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            zhou = pl.transform.up * -Mathf.Sin(dtheta);
            rot = new Quaternion(zhou.x, zhou.y, zhou.z, Mathf.Cos(dtheta));
            this.transform.rotation = rot * this.transform.rotation;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            zhou = pl.transform.up * Mathf.Sin(dtheta);
            rot = new Quaternion(zhou.x, zhou.y, zhou.z, Mathf.Cos(dtheta));
            this.transform.rotation = rot * this.transform.rotation;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            zhou = pl.transform.right * -Mathf.Sin(dtheta);
            rot = new Quaternion(zhou.x, zhou.y, zhou.z, Mathf.Cos(dtheta));
            this.transform.rotation = rot * this.transform.rotation;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            zhou = pl.transform.right * Mathf.Sin(dtheta);
            rot = new Quaternion(zhou.x, zhou.y, zhou.z, Mathf.Cos(dtheta));
            this.transform.rotation = rot * this.transform.rotation;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            locked ^= 1;
            //Physics.gravity = pl.transform.up * -9.8f;
        }
        if(locked == 1) Physics.gravity = pl.transform.forward * 9.8f;
        //Debug.Log(Physics.gravity);
        //this.transform.rotation = rotation * this.transform.rotation;
    }
}
