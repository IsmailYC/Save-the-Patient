using UnityEngine;
using System.Collections;

public class LevelsPanelScript : MonoBehaviour {
    public int nbrLevels;
    public GameObject levelBtnPrefab;
    public float btnSize;

    RectTransform rectTransform;
    float height, width;
	// Use this for initialization
	void Start () {
        rectTransform = GetComponent<RectTransform>();
        width = rectTransform.rect.size.x;
        FillPanel();
    }
	
	void FillPanel()
    {
        int btnPerRow = Mathf.FloorToInt(width / btnSize);
        int btnPerColumn = nbrLevels / btnPerRow + 1;
        rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, btnPerColumn * btnSize);
        for (int i = 0; i < btnPerColumn; i++)
        {
            for (int j = 0; j < btnPerRow; j++)
            {
                if (i * btnPerRow + j + 1 <= nbrLevels)
                {
                    GameObject tempButton = (GameObject)Instantiate(levelBtnPrefab);
                    LevelButtonScript tempLevelBtnScript = tempButton.GetComponent<LevelButtonScript>();
                    tempLevelBtnScript.SetLevel(i * btnPerRow + j + 1);
                    RectTransform tempButtonRectTransform = tempButton.GetComponent<RectTransform>();
                    tempButtonRectTransform.SetParent(rectTransform);
                    tempButtonRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, btnSize);
                    tempButtonRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, btnSize);
                    tempButtonRectTransform.anchoredPosition = new Vector2(j * btnSize, -i * btnSize);
                    tempButtonRectTransform.localScale = Vector3.one;
                }
            }
        }
    }
}
