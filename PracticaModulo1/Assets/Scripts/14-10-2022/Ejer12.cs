using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i < 100)
        {
            i += 2;

            Debug.Log("este número es par " + i);

        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
