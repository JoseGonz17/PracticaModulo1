using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer9 : MonoBehaviour
{
    public int min, max; 
    int resultado = 0;



    // Start is called before the first frame update
    void Start()
    {
        if (min > max)
            return;
        for (int i = min; i < max; i++)
        {
            resultado += i;
          
        }
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
