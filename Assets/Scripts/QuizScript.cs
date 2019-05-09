using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour {
    public string[] quizText;
    public Button[] quizButton;
    public Text[] quizDisplay;
    public int answer;

	// Use this for initialization
	void Start () {
        SetUpQuiz();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SetUpQuiz()
    {
        SetUpText();
        SetUpButton();
    }

    void SetUpText()
    {
        for(int i=0; i<quizDisplay.Length; i++)
            quizDisplay[i].text = quizText[i];
    }

    void SetUpButton()
    {
        for (int i = 0; i < quizButton.Length; i++)
        {
            int temp = i;
            quizButton[i].onClick.AddListener(() => CheckAnswer(temp));
        }

    }

    void CheckAnswer(int c)
    {
        Debug.Log(c + "," + answer);
        if (c == answer)
            GameManager.instance.WinQuiz();
        else
            GameManager.instance.Lose();
    }
}
