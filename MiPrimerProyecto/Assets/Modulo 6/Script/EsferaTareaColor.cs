using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaTareaColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        GameObject.Find("EsferaTarea").GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        Debug.Log("Se cambio el color de la esfera desde FixedUpdate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
