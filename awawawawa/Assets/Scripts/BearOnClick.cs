using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BearOnClick : MonoBehaviour {

    GameObject TextOso;

    // Use this for initialization
    void Start () {
        TextOso = GameObject.Find("TextOso");
        TextOso.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        //TextOso.SetActive(false);

        if (Input.GetKey(KeyCode.Escape))
            SceneManager.LoadScene("MenuPpal");
    }


}
