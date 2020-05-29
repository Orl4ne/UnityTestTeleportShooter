using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceBulletBehaviour : BulletBehaviour
{
    [Range(0,10)]
    public float timeBeforeDestroy;
    void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Bounce"))
            Destroy(GetComponent<Rigidbody>());
            Destroy(gameObject, timeBeforeDestroy);
    }
}
