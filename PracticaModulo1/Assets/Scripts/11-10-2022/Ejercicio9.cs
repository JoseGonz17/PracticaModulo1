using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public float area;
    public float radio;
    // Start is called before the first frame update
    void Start()
    {
        area = Mathf.PI * (radio * radio);
        Debug.Log("el area del circulo es " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
