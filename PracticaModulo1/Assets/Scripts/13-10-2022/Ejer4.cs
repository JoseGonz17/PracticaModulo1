using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer4 : MonoBehaviour
{
    public int mes;

    // Start is called before the first frame update
    void Start() 
    {
        switch (mes)
        {
            case 1:
                Debug.Log("enero");
                break;
            case 2:
                Debug.Log("febrero");
                break;
            case 3:
                Debug.Log("marzo");
                break;
            case 4:
                Debug.Log("abril");
                break;
            case 5:
                Debug.Log("mayo");
                break;
            case 6:
                Debug.Log("junio");
                break;
            case 7:
                Debug.Log("julio");
                break;
            case 8:
                Debug.Log("agosto");
                break;
            case 9:
                Debug.Log("septiembre");
                break;
            case 10:
                Debug.Log("octubre");
                break;
            case 11:
                Debug.Log("noviembre");
                break;
            case 12:
                Debug.Log("diciembre");
                break;
            default:
                Debug.Log("ese mes no exise");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
