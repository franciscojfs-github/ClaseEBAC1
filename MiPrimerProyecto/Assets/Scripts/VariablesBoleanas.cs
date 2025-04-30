using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBoleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    int limiteInferior = -5;
    int limiteSuperior = 5;
    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris,
    }
    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;
        //if (variable1 && variable2)     //si el resultado de AND operacion es verdadero entra al if
        if ((variable1 || variable2) && variable3)       //primero hace OR y luego hace AND, si es TRUE entra al if
        {
            Debug.Log("La operacion 1 es verdadero");
        }
        else if ((variable1 || variable2) || variable3)     //else if -> se anidan, si se cumple la primera condicion ya no hace las demas. se encadenan, no se van a elegir todas. Solo se toma uno de los resultados
        {
            Debug.Log("La operacion 2 es verdadero");
        }
        else if ((variable2 && variable3) || variable1)
        {
            Debug.Log("La operacion 3 es verdadero");
        }
        
        /*
        if (variable1 == true)
        {
            Debug.Log("Esta variable1 es verdadera");
            Debug.Log("Ya tienes el valor de la variable1");
        }
        if(valor1 <= 5)
        {
            Debug.Log("Valor1 es menor o igual a 5");
        }
        */

        valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1);

        /*
        switch(valor1)
        {
            case (int)SeleccionColor.rojo when variable2 == true:  //doble condicional, si cae switch 0 (rojo) se iria a default porque no se cumple la condicion de variable2
                Debug.Log("el color seleccionado es rojo");
                break;
            case (int)SeleccionColor.verde when variable1 == true: //doble condicional
                Debug.Log("el color seleccionado es verde");
                break;
            case (int)SeleccionColor.azul:
                Debug.Log("el color seleccionado es azul");
                break;
            case (int)SeleccionColor.blanco:
                Debug.Log("el color seleccionado es blanco");
                break;
            case (int)SeleccionColor.gris:
                Debug.Log("el color seleccionado es gris");
                break;
            default:
                Debug.Log("Ese no es un color valido");
                break;
        }
        */

        //Seccion de IF con Else puede ser reemplazada por una linea de codigo con String
        //if (valor1 >= 0)
        //{
        //    Debug.Log("El valor es positivo");
        //}
        //else
        //{
        //    Debug.Log("El valor es negativo");
        //}

        string resultado = (valor1 >= 0) ? "El valor es positivo" : "El valor es negativo";
        // el "?" significa que lo anterior es un condicional y si se cumple se escribe el valor. Los ":" describe que pasa si no se cummple el condicional
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
