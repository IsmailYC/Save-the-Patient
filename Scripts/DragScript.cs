using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragScript : MonoBehaviour {
    Vector2 mousePosition;

    ScaleScript scaleScript;
    bool toggle;
	// Use this for initialization
	void Awake () {
        scaleScript = GetComponent<ScaleScript>();
	}

    void Update()
    {
        if(toggle)
        {
            if (Input.GetMouseButtonDown(1))
            {
                LoseFocus();
                return;
            }
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePosition;
        }
    }

    private void OnMouseDown()
    {
        scaleScript.Scale();
        Cursor.visible = false;
        toggle = true;
    }

    void Focus()
    {
        Cursor.visible = false;
        toggle = true;
    }

    public void LoseFocus()
    {
        Cursor.visible = true;
        toggle = false;
    }
}
