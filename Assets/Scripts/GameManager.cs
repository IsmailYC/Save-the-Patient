using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public GameObject mainPanel;
    public GameObject winPanel;
    WinPanelScript winPanelScript;
    public GameObject losePanel;
    public GameObject Spawner;


    int sceneIndex;
    float startTime;
	// Use this for initialization
	void Start () {
        if (instance == null)
            instance = this;
        winPanelScript = winPanel.GetComponent<WinPanelScript>();
        sceneIndex= SceneManager.GetActiveScene().buildIndex;
        PlayerPrefManager.SetLevel(sceneIndex);
        Camera.main.aspect = 16f / 9f;
        Time.timeScale = 1.0f;
	}

    public void StartCounter()
    {
        startTime = Time.time;
    }

    public void Win(float waitTime)
    {
        mainPanel.SetActive(false);
        winPanel.SetActive(true);
        float winTime = Time.time - startTime-waitTime;
        winPanelScript.ShowResult(winTime,sceneIndex);
        Time.timeScale = 0.0f;
    }

    public void WinQuiz()
    {
        mainPanel.SetActive(false);
        winPanel.SetActive(true);
        winPanelScript.ShowResultQuiz(sceneIndex);
        Time.timeScale = 0.0f;
    }

    public void Lose()
    {
        mainPanel.SetActive(false);
        losePanel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void Retry()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void LoadMenuLevel()
    {
        SceneManager.LoadScene(0);
    }
}
