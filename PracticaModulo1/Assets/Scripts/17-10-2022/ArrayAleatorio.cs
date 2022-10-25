using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAleatorio
{
    public float[] array;

    public void ShowArray() 
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(10, 100);
        }

    }
}
