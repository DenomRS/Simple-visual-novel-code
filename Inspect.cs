using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inspect : MonoBehaviour {

    public GameObject inspectWindow;
   

  

	// Use this for initialization
	void Start () {
        inspectWindow.SetActive(false);
       
    }
	
	// Update is called once per frame
	void Update () {

     
		
	}

    public void EnableWindow()
    {
 
      
        inspectWindow.SetActive(true);
    }

    public void DisableWindow()
    {
        inspectWindow.SetActive(false);
    }
}
