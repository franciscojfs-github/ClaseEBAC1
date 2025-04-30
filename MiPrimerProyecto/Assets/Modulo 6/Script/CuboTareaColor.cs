using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboTareaColor : MonoBehaviour
{
    // Entregable Game Object 2

    public GameObject CuboColor;
    public static bool VarBool2;        

    // private void Awake()
    //{
    //    CuboColor = this.gameObject; //se selecciona el GO desde UI en Unity
    //}

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        VarBool2 = !VarBool2;
        //Debug.Log("Varbool2 Cubo es " + VarBool2);
        Color ColorGO2 = (VarBool2 == true) ? Color.white : Color.black;
        CuboColor.GetComponent<MeshRenderer>().material.color = ColorGO2;

    }
    // Update is called once per frame
    void Update()
    {
        // CuboColor.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        // Debug.Log("Se cambio el color del Cubo desde Update");
        
    }

}
