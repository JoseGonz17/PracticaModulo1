using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public float numero1;
    public float numero2;
    public float numero3;



    // Start is called before the first frame update
    void Start()
    {
        if (numero1 == numero2 && numero1 == numero3)
        {                                                                                         
            Debug.Log("este triangulo es equilatero");


        }
        else if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3) 
        {           
            Debug.Log("es te triangulo es isosceles");               
        
            
        }
        else
        {
            Debug.Log("este triangulo es escaleno");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
