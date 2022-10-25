using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            OnPlayerEnter(other.gameObject);
        }
    }

    public void OnPlayerEnter(GameObject gameObject)
    {
    }
}