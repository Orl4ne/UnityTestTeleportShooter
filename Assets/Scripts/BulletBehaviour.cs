using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float initialForce;
    public Transform playerTransform;
    //public AudioSource impactSound;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * initialForce, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Teleport"))
        {
            playerTransform.position = collision.GetContact(0).point;
        }
        //impactSound.Play();

        if (!collision.collider.CompareTag("Bounce"))
            Destroy(gameObject);
    }
}
