using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CapsulaTareaColor : MonoBehaviour
{
    public GameObject CapsulaColor;

    private void Awake()
    {
        
        CapsulaColor = this.gameObject;
        CapsulaColor.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        Debug.Log("Se cambio el color de la capsula desde Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
