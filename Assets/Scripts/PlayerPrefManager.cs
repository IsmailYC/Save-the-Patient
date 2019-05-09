using UnityEngine;
using System.Collections;

public static class PlayerPrefManager{
    public const string HIGHSCORE = "HighScore";
    public const string STARS = "Stars";
    public const string LEVEL = "Level";
    public const string SOUND = "Sound";
    public const string ZOOM = "zoom";

    public static void SetLevelHighScore(int i, float t)
    {
        if(GetLevelHighScore(i)<t)
            PlayerPrefs.SetFloat(HIGHSCORE + i.ToString(), t);
    }

    public static void SetLevelStars(int i, int s)
    {
        if(GetLevelStars(i)<s)
            PlayerPrefs.SetInt(STARS + i.ToString(), s);
    }

    public static void SetLevel(int i)
    {
        if(GetLevel()<i)
            PlayerPrefs.SetInt(LEVEL, i);
    }

    public static void SetSound(bool s)
    {
        if (s)
            PlayerPrefs.SetInt(SOUND, 1);
        else
            PlayerPrefs.SetInt(SOUND, 0);
    }

    public static void SetZoom(bool z)
    {
        if (z)
            PlayerPrefs.SetInt(ZOOM, 1);
        else
            PlayerPrefs.SetInt(ZOOM, 0);
    }

    public static float GetLevelHighScore(int i)
    {
        if (PlayerPrefs.HasKey(HIGHSCORE + i.ToString()))
            return PlayerPrefs.GetFloat(HIGHSCORE + i.ToString());
        else
            return 0f;
    }

    public static int GetLevelStars(int i)
    {
        if (PlayerPrefs.HasKey(STARS + i.ToString()))
            return PlayerPrefs.GetInt(STARS + i.ToString());
        else
            return 0;
    }

    public static int GetLevel()
    {
        if (PlayerPrefs.HasKey(LEVEL))
            return PlayerPrefs.GetInt(LEVEL);
        else
            return 1;
    }

    public static bool GetSound()
    {
        if (PlayerPrefs.HasKey(SOUND))
            return PlayerPrefs.GetInt(SOUND) == 1;
        else
            return true;
    }

    public static bool GetZoom()
    {
        if (PlayerPrefs.HasKey(ZOOM))
            return PlayerPrefs.GetInt(ZOOM) == 1;
        else
            return false;
    }
}
