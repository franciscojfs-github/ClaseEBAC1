using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGameObject4 : MonoBehaviour
{

    // Entregable Game Object 4

    // Start is called before the first frame update

    public bool VarBool4;
    
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        VarBool4 = CapsulaTareaColor.VarBool1 || CuboTareaColor.VarBool2;
        Color ColorGO4 = (VarBool4 == true) ? Color.white : Color.black;
        GameObject.Find("GameObject4").GetComponent<MeshRenderer>().material.color = ColorGO4;
        //Debug.Log("Desde GO4 VarBool1 = " + CapsulaTareaColor.VarBool1);
        //Debug.Log("Desde GO4 VarBool2 = " + CuboTareaColor.VarBool2);
        //Debug.Log("VarBool4 = " + VarBool4);

        // Debug.Log("Se cambio el color de la esfera desde FixedUpdate");
    }



    // Update is called once per frame
    void Update()
    {

    }

}
