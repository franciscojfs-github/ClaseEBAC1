using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ScriptGameObject5 : MonoBehaviour
{
    public GameObject GameObjectNo5;
    public EsferaTareaColor GO3;
    public EsferaTareaColor1 GO4;
    bool VarBool5;

    private void Awake()
    {
        GameObjectNo5 = this.gameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject GameObject3 = GameObject.Find("EsferaTarea");
        GameObject GameObject4 = GameObject.Find("EsferaTarea (1)");

        GO3 = GameObject3.GetComponent<EsferaTareaColor>();
        GO4 = GameObject4.GetComponent<EsferaTareaColor1>();
    }

    private void FixedUpdate()
    {
        VarBool5 = GO3.VarBool3 && GO4.VarBool4;
        Color ColorGO5 = VarBool5 ? Color.white : Color.black;
        GameObjectNo5.GetComponent<MeshRenderer>().material.color = ColorGO5;

        //Debug.Log("VarBool3 desde GO5 es " + GO3.VarBool3);
        //Debug.Log("VarBool4 desde GO5 es " + GO4.VarBool4);
        //Debug.Log("VarBool5 es " + VarBool5);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
