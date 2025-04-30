using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaTareaColor : MonoBehaviour
{

    // Entregable Game Object 3

    // Start is called before the first frame update

    public bool VarBool3;
    //public CuboTareaColor CuboTareaColor;
    
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        VarBool3 = CapsulaTareaColor.VarBool1 && CuboTareaColor.VarBool2;
        Color ColorGO3 = (VarBool3 == true) ? Color.white : Color.black;
        GameObject.Find("EsferaTarea").GetComponent<MeshRenderer>().material.color = ColorGO3;

        //Debug.Log("Desde GO3 VarBool1 = " + CapsulaTareaColor.VarBool1);
        //Debug.Log("Desde GO3 VarBool2 = " + CuboTareaColor.VarBool2);
        //Debug.Log("VarBool3 = " + VarBool3);

        // Debug.Log("Se cambio el color de la esfera desde FixedUpdate");
    }



    // Update is called once per frame
    void Update()
    {

    }

}
