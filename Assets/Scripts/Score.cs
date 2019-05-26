using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour {
    public TextMesh currentscore;
    public GameObject ballPrefab;
    public Transform paddleObj;
    GameObject ball;
    int score;
	
	void Update () {
        ball = GameObject.FindGameObjectWithTag("Ball");
        currentscore.text = "" + score;
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
          
            score += 1;
            Destroy(ball);
            (Instantiate(ballPrefab, new Vector3(paddleObj.transform.position.x + 2,paddleObj.transform.position.y, 0),Quaternion.identity)as GameObject).transform.parent = paddleObj;
            if(score==5)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
