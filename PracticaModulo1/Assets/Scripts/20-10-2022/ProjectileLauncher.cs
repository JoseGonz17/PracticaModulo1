using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public Transform shootbPoint;
    public GameObject projectilePrefab;

    public float timeToShoot = 1;
    private float timeSinceLastShoot = 0;

    // Update is called once per frame
    private void Update()
    {
        timeSinceLastShoot += Time.deltaTime;
        if (timeSinceLastShoot >= timeToShoot)
        {
            Instantiate(projectilePrefab, shootbPoint.position, shootbPoint.rotation);
            timeSinceLastShoot = 0;
        }
    }
}