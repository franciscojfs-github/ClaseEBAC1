using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CapsulaTareaColor : MonoBehaviour
{
    // Entregable Game Object 1

    public GameObject CapsulaColor;
    public static bool VarBool1;    

    private void Awake()
    {
        CapsulaColor = this.gameObject;
        //CapsulaColor.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        //Debug.Log("Se cambio el color de la capsula desde Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        VarBool1 = !VarBool1;
        //Debug.Log("Varbool1 Capsula es " + VarBool1);
        if (VarBool1 == true)
        {
            CapsulaColor.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            CapsulaColor.GetComponent<MeshRenderer>().material.color = Color.black;
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
