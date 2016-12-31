using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelButtonScript : MonoBehaviour {
    public Image[] stars;
    public Sprite star;
    public Text levelText;

    int level;
    Button button;
	// Use this for initialization
	void Awake () {
        button = GetComponent<Button>();
        button.onClick.AddListener(LoadLevel);
	}
	
	void LoadLevel()
    {
        SceneManager.LoadScene(level);
    }

    public void SetLevel(int l)
    {
        level = l;
        SetButton();
    }

    void SetButton()
    {
        levelText.text = level.ToString();
        SetStars();
        if (level <= PlayerPrefManager.GetLevel())
            button.interactable = true;
        else
            button.interactable = false;
    }

    void SetStars()
    {
        int nbrStars = PlayerPrefManager.GetLevelStars(level);
        for (int i = 0; i < nbrStars; i++)
            stars[i].sprite = star;
    }
}
