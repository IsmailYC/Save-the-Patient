using UnityEngine;
using System.Collections;

public class CureInteractionScript : MonoBehaviour {
    public float secondsToWin;
    public Sprite[] sprites;

    int spriteCounter;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteCounter = 0;
    }

    public void Heal()
    {
        spriteRenderer.sprite = sprites[spriteCounter];
        spriteCounter++;
        if (spriteCounter == sprites.Length)
            Invoke("Win", secondsToWin);
    }

    public void Win()
    {
        GameManager.instance.Win(secondsToWin);
    }
}
