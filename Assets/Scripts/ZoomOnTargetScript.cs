using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOnTargetScript : MonoBehaviour {
    public Transform target;
    public float size;

    bool zoom;
    bool toggle;
    float initialSize;
    Vector3 initialPosition;
    Vector2 mousePosition;
	// Use this for initialization
	void Start () {
        toggle = false;
        zoom = PlayerPrefManager.GetZoom();
        initialSize = Camera.main.orthographicSize;
        initialPosition = transform.position;
        Debug.Log(zoom);   		
	}
	
	// Update is called once per frame
	void Update () {
        if(toggle)
        {
            transform.position = new Vector3(target.position.x, target.position.y, initialPosition.z);
        }
    }

    public void ZoomOn()
    {
        if(zoom)
        {
            Camera.main.orthographicSize = size;
            toggle = true;
        }
    }
}
