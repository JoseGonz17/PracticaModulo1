using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebasUnity : MonoBehaviour
{
    //public MeshRenderer mesh;
    //mesh.material.color = new Color(102/100, 255/100,51/100);
    //public GameObject MiObjecto;

    public Transform miTransform;

    // Start is called before the first frame update
    private void Start()
    {
        Vector3 nuevaScale = new Vector3(2, 3, 2);
        miTransform.localScale = nuevaScale;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}

//for (int i = 0; i < MyObject.Length; i++)
//{
//    MyObject[i].SetActive(false);
//    Destroy(MyObject[i]);
//}

//if (MiObjecto.CompareTag("Player"))
//{
//    Debug.Log("Es el player");
//}
//else
//{
//    Debug.Log("No es el player");
//}