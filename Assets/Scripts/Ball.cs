using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float ballVelocity=300;
    Rigidbody rb;
    bool IsPlay;
    int rendInt;
	// Use this for initialization
	void Awake () {
        rb = gameObject.GetComponent<Rigidbody>();
        rendInt = Random.Range(1, 3);
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButton(0)==true&&IsPlay == false)

        {
            transform.parent = null;
            IsPlay = true;
            rb.isKinematic = false;
            if(rendInt ==1)
            {
                rb.AddForce(new Vector3(ballVelocity, ballVelocity, 0));
            }
            if(rendInt ==2)
            {
                rb.AddForce(new Vector3(-ballVelocity, -ballVelocity, 0));
            }

        }
	}
}
