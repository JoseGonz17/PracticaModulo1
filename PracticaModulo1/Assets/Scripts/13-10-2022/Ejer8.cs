using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer8 : MonoBehaviour
{
    public int max;
    public int min;
    // Start is called before the first frame update
    void Start()
    {
        if (min > max)
        {
            return;
        }
        for (int i = min; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i + " este numero es par");
               
            }
            if (i % 2 != 0)
            {
                Debug.Log(i + " este numero es impar");
               
            }
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
