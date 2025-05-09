using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mod9EjerciciosdeCiclosyArreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1 llenar dos arreglos unidimencionales de diferentes tamanos con numeros random y luego sumarlos
        int[] arregloUni1 = new int[Random.Range(3, 5)];
        int[] arregloUni2 = new int[Random.Range(6, 8)];
        for (int i = 0; i < arregloUni1.Length; i++)
        {
            arregloUni1[i] = Random.Range(0, 9);        //se llena el array con numeros aleatorios
            Debug.Log($"Arreglo 1[{i}] es {arregloUni1[i]}");
        }
        for (int i = 0; i < arregloUni2.Length; i++)
        {
            arregloUni2[i] = Random.Range(0, 9);
            Debug.Log($"Arreglo 2[{i}] es {arregloUni2[i]}");
        }

        int maxLenght = (arregloUni1.Length > arregloUni2.Length) ? arregloUni1.Length : arregloUni2.Length;        //determina el lenght del array mas chico y mas grande
        int minLenght = (arregloUni1.Length > arregloUni2.Length) ? arregloUni2.Length : arregloUni1.Length;
        int[] arregloUni3 = new int[minLenght];     //siguiendo el ejemplo del ejercicio "arr3[5] = arr1[5]+arr[6]" el tercer arreglo suma es del tamano del mas chico [5]
        for (int i = 0; i < minLenght; i++)
        {
            arregloUni3[i] = arregloUni1[i] + arregloUni2[i];
            Debug.Log($"La suma es Arreglo3[{i}] es {arregloUni3[i]}");
        }

        //una segunda opcion mejorada. el tamano del tecer arreglo (resultado de la suma) es del tamano del arreglo mas grande (como si se hubieran llenado con ceros en el arreglo mas pequeno)
                //arr3[5] = arr1[5] + arr2[3]
        int[] arregloUni3b = new int[maxLenght];
        for (int i = 0; i < minLenght; i++)
        {               //primer suma el arreglo 1 + 2
            arregloUni3b[i] = arregloUni1[i] + arregloUni2[i];
            Debug.Log($"La suma correcta es Arreglo 3b[{i}] es {arregloUni3b[i]}");
        }
        for (int i = minLenght; i < maxLenght; i++)
        {               //despues toma los numeros que no se sumaron del arreglo mas grande (1 o 2) y los guarda en (3)
            arregloUni3b[i] = (arregloUni1.Length > arregloUni2.Length) ? arregloUni1[i] : arregloUni2[i];  //compara si el arreglo 1 o 2 es mas grande; toma el mas grande y guarda los valores en arreglo-suma 3 en los espacios restantes 
            Debug.Log($"La suma correcta es Arreglo 3b[{i}] es {arregloUni3b[i]}");
        }

        //2: Crear un arreglo de strings con oracion. usando foreach concatenar e imprimir oracion completa en un string
        string[] arregloString1 = { "Hoy", "va", "ser", "un", "buen", "dia" };
        string stringJunto = "";
        //ejemplo con un ciclo for
        for (int i = 0; i < arregloString1.Length; i++)
        {
            stringJunto = stringJunto + arregloString1[i] + " ";
        }
        Debug.Log("Usando for. El arreglo en un solo string dice: " + stringJunto);
        
        //ejemplo con un ciclo foreach
        string stringJunto2 = "";
        foreach (string tempString in arregloString1)
        {
            stringJunto2 += tempString + " ";
        }
        Debug.Log ($"Usando foreach dice: {stringJunto2}");

        //3 crear arreglo bidiemensional y multiplicar por arreglo unidimencional
        //the number of columns in the first matrix must match the number of elements in the second (vector or matrix)
        int[,] arregloBi1 =                                               // 3x4 arreglo [x,y]
            { { 0, 1, 2, 3 },
            { 4, 5, 6, 7 },              //cuando [x,y] * [z] = w; x,y,z,w son el tamano del arreglo (no los valores por si mismos)
            { 8, 9, 0, 1 } };     
        int[] arregloUni4 = { 1, 2, 3, 4 };                              //[z] = y en [x,y]; z tiene que ser igual a y (en tamano)
        int[] arregloResultado1 = new int[arregloBi1.GetLength(1)];      //GetLengh(0) en [x,y] es x; (1) es y
        int suma1 = 0;                                                   //se suman los valores multiplicados
        int[] arregloFinal = new int[arregloBi1.GetLength(0)];           // w = x; el tamano del arreglo resultado es igual a x cuando [x,y] es el dimensional
        string stringResultado = "";    //extra para mostrar arreglo en un solo mensaje
        string stringarreglo1 = "";     //extra para mostrar arreglo en un solo mensaje      
        string stringarreglo2 = "";     //extra para mostrar arreglo en un solo mensaje
        for (int i = 0; i < arregloBi1.GetLength(0); i++)
        {
            for (int j = 0; j < arregloUni4.Length; j++)
            {
                arregloResultado1[j] = (arregloBi1[i,j] * arregloUni4[j]);
                suma1 += arregloResultado1[j];
                stringarreglo1 += ($"{arregloBi1[i, j]} ");     //extra para mostrar arreglo en un solo mensaje
                stringarreglo2 = (i == 0) ? stringarreglo2 + arregloUni4[j] + " " : stringarreglo2;     //extra para mostrar arreglo en un solo mensaje
            }
            arregloFinal[i] = suma1;
            //Debug.Log (arregloFinal[i]);
            suma1 = 0;
            stringarreglo1 += "\n";     //extra para mostrar arreglo en un solo mensaje

            //extra para escribir el resultado arreglo en una sola linea separado por comas
            if (i < arregloBi1.GetLength(0) - 1)
            {
                stringResultado += arregloFinal[i] + ", ";
            }
            else
            {
                stringResultado += arregloFinal[i];
            }

        }
        Debug.Log ("El arreglo 1 es :\n" + stringarreglo1);
        Debug.Log("El arreglo 2 es :\n" +  stringarreglo2);
        Debug.Log ($"El restulado es\n[{stringResultado}]");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
