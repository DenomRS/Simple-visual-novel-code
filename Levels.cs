using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Levels : MonoBehaviour {

    

    public GameObject loadingScreen;
    public Slider slider;

    AsyncOperation async;

    // Use this for initialization
    void Start()
    {
        

    }
    // Update is called once per frame
    void Update () {
		
	}

    

    public void RestryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        

    }

    public void LoadTittle()
    {
        StartCoroutine(LoadingScreen("Menu"));
        Time.timeScale = 1f;
    }

    public void Credits()
    {
        StartCoroutine(LoadingScreen("Credits"));
        Time.timeScale = 1f;
    }

    public void Chapters()
    {
        StartCoroutine(LoadingScreen("Chapters"));
        Time.timeScale = 1f;
    }

    public void Intro()
    {
        StartCoroutine(LoadingScreen("Intro"));
        Time.timeScale = 1f;
    }

    public void Chap2()
    {
        StartCoroutine(LoadingScreen("Chap2"));
        Time.timeScale = 1f;
    }


    //--------------------------ESPAÑOL----------------------------

    public void LoadTittleESP()
    {
        StartCoroutine(LoadingScreen("MenuESP"));
        Time.timeScale = 1f;
    }

    public void CreditsESP()
    {
        StartCoroutine(LoadingScreen("CreditsESP"));
        Time.timeScale = 1f;
    }

    public void ChaptersESP()
    {
        StartCoroutine(LoadingScreen("ChaptersESP"));
        Time.timeScale = 1f;
    }

    public void IntroESP()
    {
        StartCoroutine(LoadingScreen("IntroESP"));
        Time.timeScale = 1f;
    }



    public void Chap2ESP()
    {
        StartCoroutine(LoadingScreen("Chap2ESP"));
        Time.timeScale = 1f;
    }



    //---------------------Load screen---------------------------

    IEnumerator LoadingScreen(string sceneName)
    {

        loadingScreen.SetActive(true);
        async = SceneManager.LoadSceneAsync(sceneName);
        async.allowSceneActivation = false;

        while (async.isDone == false)
        {
            slider.value = async.progress;
            if (async.progress == 0.9f)
            {
                slider.value = 1f;
                async.allowSceneActivation = true;
            }
            yield return null;
        }

    }
}
