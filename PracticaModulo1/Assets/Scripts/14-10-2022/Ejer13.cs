using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 501;

        do
        {
            if (i<=500)
            {
                
                Debug.Log("este número es impar " + i);
            }
            i-=2;
        } while (i > 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
