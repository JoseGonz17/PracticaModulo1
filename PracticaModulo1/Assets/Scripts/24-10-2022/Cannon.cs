using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform shootPoint;

    public GameObject cannonballPrefab;

    public float shootForce;

    public float timeToShoot;

    private float timeSinceLastShoot;

    public void Shoot()
    {
        GameObject cannonball = Instantiate(cannonballPrefab, shootPoint.position, shootPoint.rotation);

        Rigidbody cannonRigidbody = cannonball.GetComponent<Rigidbody>();
        cannonRigidbody.AddForce(shootPoint.forward * shootForce, ForceMode.Impulse);
    }

    private void Update()
    {
        timeSinceLastShoot += Time.deltaTime;

        if (timeSinceLastShoot > timeToShoot)
        {
            Shoot();
            timeSinceLastShoot = 0;
        }
    }
}