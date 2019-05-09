using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinPanelScript : MonoBehaviour {
    public Image[] starImages;
    public Sprite star;
    public Text timeText;
    public float threeStarTime;

    public void ShowResult(float time, int level)
    {
        if (time <= threeStarTime)
        {
            starImages[0].sprite = star;
            starImages[1].sprite = star;
            starImages[2].sprite = star;
            PlayerPrefManager.SetLevelStars(level, 3);
        }
        else if (time <= 1.5f * threeStarTime)
        {
            starImages[0].sprite = star;
            starImages[1].sprite = star;
            PlayerPrefManager.SetLevelStars(level, 2);
        }
        else
        { 
            starImages[0].sprite = star;
            PlayerPrefManager.SetLevelStars(level, 1);
        }
        timeText.text = time.ToString("F2");
        PlayerPrefManager.SetLevelHighScore(level, time);
        PlayerPrefManager.SetLevel(level + 1);
    }

    public void ShowResultQuiz(int level)
    {
        starImages[0].sprite = star;
        starImages[1].sprite = star;
        starImages[2].sprite = star;
        PlayerPrefManager.SetLevelStars(level, 3);
        timeText.text = "";
    }
}
