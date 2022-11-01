using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProyectile : MonoBehaviour
{
    public float timeToDestroy = 3;

    private void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
}
