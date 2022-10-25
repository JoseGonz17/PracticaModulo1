using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porteria : Player
{
    public void OntriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnPlayerEnter(other.gameObject);
            Debug.Log("La pelota ha entrado a la portería");
        }
    }
}