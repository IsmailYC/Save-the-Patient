using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {
    public GameObject[] obstacles;
    public float[] times;
    public GameObject cure;

    int index;
	// Use this for initialization
	void Start () {
        index = 0;
        Invoke("Spawn", times[index]);
	}
	
	// Update is called once per frame
	void Update () {
        if (index >= obstacles.Length && transform.childCount <= 0)
        {
            GameManager.instance.WinQuiz();
            cure.GetComponent<DragScript>().LoseFocus();
        }
	}

    void Spawn()
    {
        GameObject temp = (GameObject)Instantiate(obstacles[index], transform.position, transform.rotation);
        temp.transform.parent = transform;
        index++;
        if (index < times.Length)
            Invoke("Spawn", times[index]);
    }
}
