using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer11 : MonoBehaviour
{
    public int max, min;
    int num = 1;

    // Start is called before the first frame update
    void Start()
    {
        if (min > max)
        {
            return;
        }
        for (int i = min; i <= max; i++)
        {
            num += i;

            if (i % num == num && num % num == 1)
            {
                Debug.Log("este numero es primo " + num);
                break;

            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
