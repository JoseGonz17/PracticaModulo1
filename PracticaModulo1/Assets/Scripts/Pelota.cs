using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    private string playerTag = "Pelota";
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            OnPlayerEnter(other.gameObject);
        }
    }
    public GameObject Moneda;
    public void OnPlayerEnter(GameObject gameObject)
    {
        Moneda.SetActive(true);
    }

}
