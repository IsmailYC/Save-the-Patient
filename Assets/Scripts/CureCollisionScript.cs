using UnityEngine;
using System.Collections;

public class CureCollisionScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<DragScript>().LoseFocus();
        if (other.gameObject.tag == "Outline")
        {
            Destroy(gameObject);
            GameManager.instance.Lose();
        }
        else if (other.gameObject.tag == "Target")
        {
            Destroy(gameObject);
            other.GetComponent<CureInteractionScript>().Heal();
        }
    }
}
