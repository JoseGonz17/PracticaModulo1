using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer10 : MonoBehaviour
{
    public int num1 = 1;
    public int num2 = 5;
    int res = 1;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = num1; i < num2; i++)
        {
            res *= i;

        }
        Debug.Log(res);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
