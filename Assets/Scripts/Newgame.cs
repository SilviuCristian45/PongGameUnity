using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Newgame : MonoBehaviour {

    void OnMouseDown()
    {
        transform.localScale *= 0.9F;
    }
    void OnMouseUp()
    {
        SceneManager.LoadScene(1);
    }
}
