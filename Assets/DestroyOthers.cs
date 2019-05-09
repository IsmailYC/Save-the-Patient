using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOthers : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject.transform.parent.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject.transform.parent.gameObject);
    }
}
