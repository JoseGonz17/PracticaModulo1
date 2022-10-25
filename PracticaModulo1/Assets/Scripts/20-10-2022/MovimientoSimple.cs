using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSimple : MonoBehaviour
{
    public float movingSpeed;

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 1 * movingSpeed;
    }
}