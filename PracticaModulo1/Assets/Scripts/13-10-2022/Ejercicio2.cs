using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Ejercicio2 : MonoBehaviour
{

    public int Year;



    // Start is called before the first frame update
    void Start()
    {
        if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 != 0)
        {
            Debug.Log("es un año bisiesto");
        }
        else
        {

            Debug.Log("no es un año bisiesto");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
