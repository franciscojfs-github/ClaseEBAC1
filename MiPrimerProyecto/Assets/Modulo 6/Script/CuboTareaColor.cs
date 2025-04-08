using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboTareaColor : MonoBehaviour
{
    public GameObject CuboColor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //CuboColor = this.gameObject;
        CuboColor.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        Debug.Log("Se cambio el color del Cubo desde Update");
        
    }
}
