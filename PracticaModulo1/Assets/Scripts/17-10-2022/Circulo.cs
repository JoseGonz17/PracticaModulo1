using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo
{
    public float radio = 5;
    
    public float Area()
    {
        return radio * radio * 3.14f;
    }
    
 
    public float Perimetro() 
    {
        return radio + 2 * 3.14f;
    }


}
