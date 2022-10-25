using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo
{
    float Altura = 3;
    float Base = 4;
    public float Area() 
    {
        return Altura * Base;
    }

    public float Perimetro() 
    {
        return Altura * 2 + Base * 2;
    }




}
