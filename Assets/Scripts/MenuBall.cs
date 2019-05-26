using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBall : MonoBehaviour {

    public int ballvelocity = 500;
    public Rigidbody rb;
    void Awake ()
     {
        rb = GetComponent<Rigidbody>();
        rb.AddForce( new Vector3(ballvelocity, ballvelocity, 0));


     }
}
