using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripMod9Ciclos : MonoBehaviour
{

    //int contador = 0;
    // Start is called before the first frame update
    void Start()
    {

        //while (contador < 10)
        //{
        //    contador++;
        //    Debug.Log("Hola" + contador);
        //}

        //bool miBooleano1 = false;
        //do               //se ejecuta al menos una vez
        //{
        //    Debug.Log("Hola desde el do while");
        //} while (miBooleano1);

        
        int[] miArreglo1 = new int[5];     //new instancia en memoria. en cuanto a su tamano no se puede cambiar a menos que se vuelva a declarar
        miArreglo1 = new int[7];            //sin esto no le podria asignar mas de 5 valores. Al hacer el new se esta reinicializando vacio de 7 posiciones y se borran los previos 5 elementos
        string[] diasSemana = new string[7] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };     //se puede dar el valor de cada posicion en el arreglo
        //diasSemana = { "miercoles", "jueves", "viernes", "sabado","domingo","lunes", "martes"}; //no se puede inicializar un arreglo redefiniendo todos sus valores, ni cambiar sus dimensiones. se tiene que reinicializarlo con la palabra new
        diasSemana = new string[] { "miercoles", "jueves", "viernes", "sabado", "domingo", "lunes", "martes" };     //reinicializando si se puede cambiar todos sus valores o tambien se podria cambiar su valor elemento por elemento

        for (int i = 0; i < diasSemana.Length; i++)
        {
            miArreglo1[i] = i + 1;      //se modifica el valor de un arreglo uno por uno
            Debug.Log(diasSemana[i]);
        }

        int[,] miMatriz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };      //se crea matriz bidimensional de 3x3. El ',' significa que es matriz bidimensional (mismo tamano)
        for (int j = 0; j < miMatriz.GetLength(0); j++)     //GetLenght regresa el tamano de la dimension 0 osea el tamano del primer renglon
        {
            for (int k = 0; k < miMatriz.GetLength(1); k++)
            {
                miMatriz[j, k] += +1;
                Debug.Log(miMatriz[j, k]);
            }
        }
        int[][] miArregloJagged = new int[][]     //dobles corches para Jagged. en C++ asi se declaran los arreglos bidimensionales
        {
            new int[]{1,2,3 },
            new int[]{4,5, },
            new int[]{6,7,8,9},
        };
        miArregloJagged[1] = new int[] { 10, 11, 12, 13, 14 };      //modifica la segunda linea del arreglo

        Debug.Log(miArregloJagged[0][1]);       //se accede al valor del numero 2 del arreglo

        for (int x = 0; x < miArregloJagged.Length; x++)
        {
            for (int y = 0; y < miArregloJagged[x].Length; y++)
            {
                Debug.Log(miArregloJagged[x][y]);
            }
        }
         

        int[] miArreglo2 = new int[5];     //new instancia en memoria. en cuanto a su tamano no se puede cambiar a menos que se vuelva a declarar
        miArreglo2 = new int[12];            //sin esto no le podria asignar mas de 5 valores. Al hacer el new se esta reinicializando vacio de 7 posiciones y se borran los previos 5 elementos
        for (int i = 0; i < miArreglo2.Length; i++)
        {
            miArreglo2[i] = i;
        }

        string[] diasSemana2 = new string[7] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };     //se puede dar el valor de cada posicion en el arreglo
        //diasSemana = { "miercoles", "jueves", "viernes", "sabado","domingo","lunes", "martes"}; //no se puede inicializar un arreglo redefiniendo todos sus valores, ni cambiar sus dimensiones. se tiene que reinicializarlo con la palabra new
        diasSemana2 = new string[] { "miercoles", "jueves", "viernes", "sabado", "domingo", "lunes", "martes" };     //reinicializando si se puede cambiar todos sus valores o tambien se podria cambiar su valor elemento por elemento

        foreach (int i in miArreglo2)      //por cada una de las variables dentro de esta coleccion que es lo que voy hacer. No se puede modificar  los datos dentro (ejemplo la i no se puede cambiar de valor dentro del mismo foreach, solo se pueden leer
        {
            Debug.Log(i);
        }
        foreach (string dia in diasSemana2)        //guarda en el valor "dia" cada string en diaSemana2
        {
            Debug.Log(dia);
        }
    }


    // Update is called once per frame
    void Update()
    {
        //contador++;
        //Debug.Log(contador);
    }
}
