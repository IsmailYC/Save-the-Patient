using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoundButtonScript : MonoBehaviour {
    public Sprite[] sprites;

    bool sound;
    Image image;
    Button button;
	// Use this for initialization
	void Start () {
        sound = PlayerPrefManager.GetSound();
        SetSprite();
        button = GetComponent<Button>();
        button.onClick.AddListener(ToggleSound);
	}
	
	void ToggleSound()
    {
        if(sound)
        {
            sound = false;
            PlayerPrefManager.SetSound(sound);
            SetSprite();
        }
        else
        {
            sound = true;
            PlayerPrefManager.SetSound(sound);
            SetSprite();
        }
    }

    void SetSprite()
    {
        image = GetComponent<Image>();
        if (sound)
            image.sprite = sprites[0];
        else
            image.sprite = sprites[1];
    }
}
