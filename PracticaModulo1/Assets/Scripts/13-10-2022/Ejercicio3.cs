using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public int dia;
    
    // Start is called before the first frame update
    void Start()
    {


        switch (dia)
        {
            case 1:
                Debug.Log("es lunes");
            break;
            case 2:
                Debug.Log("es martes");
            break;
            case 3:
                Debug.Log("es miercoles");
            break;
            case 4:
                Debug.Log("es jueves");
                break;
            case 5:
                Debug.Log("es viernes");
                break;
            case 6:
                Debug.Log("es sabado");
                break;
            case 7:
                Debug.Log("es domingo");
                break;



            default:
                Debug.Log("¿eres bobo o que?");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
