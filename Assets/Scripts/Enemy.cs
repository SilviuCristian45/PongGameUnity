using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float speed = 8;
    Vector3 targetPos;
    GameObject ballObj;
    Vector3 playerPos;
	
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        ballObj = GameObject.FindGameObjectWithTag("Ball");
        if(ballObj!=null)
        { 
        targetPos = Vector3.Lerp(transform.position, ballObj.transform.position, Time.deltaTime * speed);
        playerPos = new Vector3(-16, Mathf.Clamp(targetPos.y, -8.1f, 8.5f), 0);
        gameObject.transform.position = new Vector3(15, playerPos.y, 0);
        }
    }
}
