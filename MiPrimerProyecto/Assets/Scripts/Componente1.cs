using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{
    public static GameObject miObjeto;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        miObjeto = this.gameObject;
        //Se modifico el Scrip Execution Order y asi Component 1,2 y 3 pueden estar en Start
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
