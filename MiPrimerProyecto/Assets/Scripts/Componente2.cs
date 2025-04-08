using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente2 : MonoBehaviour
{
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Componente1.miObjeto.name);
        //Se modifico el Scrip Execution Order y asi Component 1,2 y 3 pueden estar en Start
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
