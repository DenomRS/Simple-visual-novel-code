using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slideshow : MonoBehaviour {


    public Text textDisplay;
    public string[] sentences;

    private int index;
    public float typeSpeed;

    public Sprite[] slide;

    public GameObject continueButton;
    public GameObject sceneButton;

    public GameObject slideTAB;


    // Use this for initialization

    void Start () {

        StartCoroutine(Type());
        sceneButton.SetActive(false);

        continueButton.SetActive(false);

        Time.timeScale = 1f;

    }
	
	// Update is called once per frame
	void Update () {

        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
        slideTAB.GetComponent<Image>().sprite = slide[index];

    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typeSpeed);
        }
    }

    public void NextSentence()
    {

        
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            sceneButton.SetActive(true);
            textDisplay.text = "";
        }
        
    }
}
