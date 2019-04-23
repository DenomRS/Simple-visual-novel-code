using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour {


    public GameObject root;
    public GameObject choice;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelectPath()
    {
        choice.SetActive(true);
        root.SetActive(false);
    }
}
