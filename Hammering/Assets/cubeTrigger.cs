using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collider")
        {
            Destroy(gameObject);
        }
    }
}
