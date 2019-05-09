using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomButtonScript : MonoBehaviour {
    public Sprite[] sprites;

    bool zoom;
    Image image;
    Button button;
    // Use this for initialization
    void Start()
    {
        zoom = PlayerPrefManager.GetZoom();
        SetSprite();
        button = GetComponent<Button>();
        button.onClick.AddListener(ToggleZoom);
    }

    void ToggleZoom()
    {
        if (zoom)
        {
            zoom = false;
            PlayerPrefManager.SetZoom(zoom);
            SetSprite();
        }
        else
        {
            zoom = true;
            PlayerPrefManager.SetZoom(zoom);
            SetSprite();
        }
    }

    void SetSprite()
    {
        image = GetComponent<Image>();
        if (zoom)
            image.sprite = sprites[0];
        else
            image.sprite = sprites[1];
    }
}
