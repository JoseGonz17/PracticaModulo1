using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private string playerTag = "Player";
    //public Transform posicionObjetivo;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Has entrado");

        if (other.gameObject.CompareTag(playerTag))
        {
            //other.transform.position = posicionObjetivo.position;
            OnPlayerEnter(other.gameObject);
        }
    }

    public virtual void OnPlayerEnter(GameObject playerObject)
    {
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("Has salido de DonCamarón");
    //}

    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log("Está usted dentro de DonCamarón");
    //}
}