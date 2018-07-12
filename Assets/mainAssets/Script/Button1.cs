using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button1 : MonoBehaviour {

    // Use this for initialization
    private void Start () {
		
	}

    // Update is called once per frame
    private void Update () {
        //Debug.Log(gameObject.name[0]);
	}

    private void OnMouseUp()
    {
        //Debug.Log(12);
        SceneManager.LoadScene((Convert.ToInt32(gameObject.name[0]))-48);
    }
}
