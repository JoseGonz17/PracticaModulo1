using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioEdad : MonoBehaviour
{

    public int edad1 = 9;
    public int edad2 = 18;
    public int resultado;

    // Start is called before the first frame update
    void Start()
    {
        if (edad1 < edad2)
        {
            Debug.Log("es menor de 18");

        }
        else 
        {

            Debug.Log("es igual o mayor de 18");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
