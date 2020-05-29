using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviour : MonoBehaviour
{
    public Transform bulletOrigin;
    public Transform playerRoot;
    public GameObject bulletPrefab;
    public GameObject traceBulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletOrigin.position, bulletOrigin.rotation);
            bullet.GetComponent<BulletBehaviour>().playerTransform = playerRoot;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            GameObject bullet = Instantiate(traceBulletPrefab, bulletOrigin.position, bulletOrigin.rotation);

        }
    }
}
