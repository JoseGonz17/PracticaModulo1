using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDardo : MonoBehaviour
{
    public float movingSpeed;

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * movingSpeed;
    }
}
