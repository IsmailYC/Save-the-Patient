using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour {
    public float xSpeed;
    public float ySpeed;
	
	// Update is called once per frame
	void Update () {
        transform.Translate((Vector3.up * ySpeed + Vector3.right * xSpeed) * Time.deltaTime);
	}
}
