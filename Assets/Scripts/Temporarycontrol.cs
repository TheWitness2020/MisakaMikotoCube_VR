using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temporarycontrol : MonoBehaviour
{
    public Vector3 up = new Vector3(1, 0, 0);
    public Vector3 down = new Vector3(-1, 0, 0);
    public Vector3 left = new Vector3(0, 1, 0);
    public Vector3 right = new Vector3(0, -1, 0);
    Quaternion gra = new Quaternion(0, -1, 0, 0);
    public float dtheta = 0.01f;
    Quaternion rotl, rotu, rotr, rotd;
    void Start()
    {
        left = left * Mathf.Sin(dtheta);
        rotl = new Quaternion(left.x, left.y, left.z, Mathf.Cos(dtheta));
        right = right * Mathf.Sin(dtheta);
        rotr = new Quaternion(right.x, right.y, right.z, Mathf.Cos(dtheta));
        up = up * Mathf.Sin(dtheta);
        rotu = new Quaternion(up.x, up.y, up.z, Mathf.Cos(dtheta));
        down = down * Mathf.Sin(dtheta);
        rotd = new Quaternion(down.x, down.y, down.z, Mathf.Cos(dtheta));
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.localRotation = rotl * this.transform.localRotation;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.localRotation = rotu * this.transform.localRotation;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.localRotation = rotd * this.transform.localRotation;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.localRotation = rotr * this.transform.localRotation;
        }
        Quaternion rec = this.transform.localRotation; //Debug.Log(rec);
        Quaternion rot = new Quaternion(-rec.x, -rec.y, -rec.z, rec.w);
        rot = Quaternion.Normalize(rec * gra * rot); //Debug.Log(rot);
        Debug.Log("***");
        Physics.gravity = new Vector3(rot.x, rot.y, rot.z) * 9.8f;
        Debug.Log(Physics.gravity);
        //this.transform.rotation = rotation * this.transform.rotation;
    }
}
