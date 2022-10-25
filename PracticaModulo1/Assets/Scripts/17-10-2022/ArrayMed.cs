using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMed 
{
    public float[] miarray;
    float suma = 0;

   

    public float MedArray(float[]miarray,float suma) 
    {
        for (int i = 0; i < miarray.Length; i++)
        {
            suma += miarray.Length;
        }
        return suma / miarray.Length;
    }

    public void ShowArray() 
    {
        Debug.Log("La media de este array es " + MedArray(miarray, suma));
    }
}
