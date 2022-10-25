using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer5 : MonoBehaviour
{
    public int Mes;
   
    // Start is called before the first frame update
    void Start()
    {
        switch (Mes)
        {
            case 1:
                Debug.Log("este mes tiene 31 dias");
                break;
            case 3:
                Debug.Log("este mes tiene 31 dias");
                break;
            case 5:
                Debug.Log("este mes tiene 31 dias");
                break;
            case 7:
                Debug.Log("este mes tiene 31 dias");
                break;
            case 8:
                Debug.Log("este mes tiene 31 dias");
                break;
            case 10:
                Debug.Log("este mes tiene 31 dias");
                break;
            case 12:
                Debug.Log("este mes tiene 31 dias");
                break;
            default:
                break;
        }
        switch (Mes)

        {
            case 2:
                Debug.Log("este mes tiene 28 dias");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Debug.Log("este mes tiene 30 dias");
                break;

            default:
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
