using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioPositivo : MonoBehaviour
{ public int numero = 0;

    // Start is called before the first frame update
    void Start()
    {
        if ( numero >= 0)
        {
            Debug.Log("este numero es positivo");
        }
        else
        {
            Debug.Log("este numero es negaivo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
