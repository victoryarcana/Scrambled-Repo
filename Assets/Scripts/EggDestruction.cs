using UnityEngine;
using System.Collections;

public class EggDestruction : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    // void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Bird>() != null)
        {
            gameObject.SetActive(false);

            // can also destroy gameobject with Destroy(gameObject);
        }
    }
}