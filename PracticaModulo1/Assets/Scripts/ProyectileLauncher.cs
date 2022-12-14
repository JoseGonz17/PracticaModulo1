using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectileLauncher : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject projectilePrefab;

    public float timeToShoot = 2;
    private float timeSinceLastShot = 0;

    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        if (timeSinceLastShot >= timeToShoot)
        {
            Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);
            timeSinceLastShot = 0;
        }
    }
}

