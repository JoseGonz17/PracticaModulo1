using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChildrens : MonoBehaviour
{
    public MeshRenderer[] mesh;

    // Start is called before the first frame update
    private void Start()
    {
        mesh = GetComponentsInChildren<MeshRenderer>();
        for (int i = 0; i < mesh.Length; i++)
        {
            mesh[i].material.color = Color.green;
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}