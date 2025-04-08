using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Componente1.miObjeto.name = "nuevoNombreDeMiObjeto";
        //Se modifico el Scrip Execution Order y asi Component 1,2 y 3 pueden estar en Start
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
