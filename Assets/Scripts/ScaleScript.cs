using UnityEngine;
using System.Collections;

public class ScaleScript : MonoBehaviour {
    public float scale;

    bool scaled;
    Vector3 originalScale;
    Vector3 newScale;
    // Use this for initialization
    void Start()
    {
        scaled = false;
        originalScale = transform.localScale;
        newScale = new Vector3(originalScale.x * scale, originalScale.y * scale, originalScale.z);
    }

    public void ToggleScale()
    {
        if (scaled)
        {
            scaled = false;
            transform.localScale = originalScale;
        }
        else
        {
            scaled = true;
            transform.localScale = newScale;
        }
    }

    public void Scale()
    {
        if (scaled)
            return;
        scaled = true;
        transform.localScale = newScale;
        GameManager.instance.StartCounter();
        //Camera.main.GetComponent<ZoomOnTargetScript>().ZoomOn();
    }

    public void ScaleBack()
    {
        if (!scaled)
            return;
        scaled = false;
        transform.localScale = originalScale;
    }
}
