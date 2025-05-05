using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int variable1;
    float variable2 = 1f;
    float variable3 = 3.33f;
    float variable4 = 3.14159f;
    int variable6;
    int variable7;
    public GameObject GO1ParImpar;
    string GO2Color;
    public GameObject GO2CaseColor;
    string[] GO2Colores = {"azul", "rojo", "verde", "negro"};
    // Start is called before the first frame update
    void Start()
    {
        //2)
        int variable5 = (int)(variable3 * variable4);   //casteo explicito del resultado de la operacion de numero flotante a numero entero 
        Debug.Log("El valor entero de la multiplicacion de flotantes es " + variable5);
        Debug.Log($"El valor flotante de la misma multiplicacion es {variable3 * variable4}");   //se agrega como ejemplo del resultado si fuera flotante para comparar vs numero entero

        //3)
        GO1ParImpar = GameObject.Find("Mod8GO1");

        //4)
        GO2CaseColor = GameObject.Find("Mod8GO2");

        //5)
        string FloatAString = variable4.ToString();     //convierte el valor a string y luego imprime los primeros 6 caracteres (1 primer numero + 1 punto + 4 decimales). Pero no funciona si la parte entera tiene mas de 1 caracter
        Debug.Log("Float a String con 4 decimales de precision " + FloatAString.Substring(0, 6));

        string FloatAString2 = variable4.ToString("F4");        //redondea a 4 decimales (cambia el numero) y luego convierte a string. Pero no imprime los valores exactos ya que primero redondea y luego imprime
        Debug.Log("Float a String con 4 decimales de precision " + FloatAString2);

        string[] FloatAStringMatriz = FloatAString.Split('.');  //Forma correcta. Divide el string en partes separadas por el caracter '.' y los guarda en una matriz
        Debug.Log($"Float a String cualquier numero con 4 decimales de precision: {FloatAStringMatriz[0]}.{FloatAStringMatriz[1].Substring(0, 4)}"); //imprime la primera parte de la matriz (numero entero) y luego la 2nda parte de la matriz (numeros decimales), pero solo imprime los caracteres del primero (0) al cuarto ,4

        //6)
        string nombreCompleto = "Francisco Javier Fernandez Sanchez";
        //string nombres = nombreCompleto.Substring(0,16);
        //string apellidoPaterno = nombreCompleto.Substring(17,9); Se puede simplificar para separar e imprimir directamente sin guardar:
        Debug.Log(nombreCompleto.Substring(0, 16));      //imprime desde el caracter 0 del string; e imprime los primeros 16 caracteres desde ahi
        Debug.Log(nombreCompleto.Substring(17, 9));
        Debug.Log(nombreCompleto.Substring(27, 7));

        string[] nombreSeparado = nombreCompleto.Split(" ");        //con el metodo split separa el nombre en una lista de strings y luego los imprime en un for uno por uno
        for (int i = 0; i < nombreSeparado.Length; i++)
        {
            Debug.Log(nombreSeparado[i]);
        }

        //Parte 2. 1)
        string stringMiles1 = "123987";
        string stringMiles2 = "294746";
        if (int.TryParse(stringMiles1, out int numeroMiles1) && int.TryParse(stringMiles2, out int numeroMiles2)) //TryParse checa si las variables se pueden convertir a numero; en caso que si guarda el valor numerico en Out numeroMiles, ademas regresa un valor TRUE o FALSE dependiendo si se cumple o no la condicion
        {
            int sumaMiles = numeroMiles1 + numeroMiles2;
            Debug.Log("El valor de la suma es " + sumaMiles);
        }
        else
        {
            Debug.LogError("Estos no son caracteres validos, deben ser numeros");
        }

        //Parte 2. 2)
        string oracion = "Hola desde Tarea Modulo 8";
        string oracionCharPar = "";
        for (int i = 0; i < oracion.Length; i += 2)     //i va en incrementos de 2 en 2, tomando solo los pares, y guardando el caracter par de cada for en oracionCharPar
        {
            oracionCharPar += oracion[i];
        }
        Debug.Log("Los caracteres en posiciones pares son: " + oracionCharPar);
        oracionCharPar = "";

        for (int i = 0; i < oracion.Length; i++)        //Segunda opcion: se va incrementando de uno en uno
        {
            if (i % 2 == 0)                             //solo los valores con residual 0 se toman en cuenta, osea pares
            {
                oracionCharPar += oracion[i];
            }
        }
        Debug.Log("Los caracteres en posiciones pares son: " + oracionCharPar);

        //Parte 2. 3)
        string oracion2 = "EsteStringTieneMasDe5Caracteres";
        string oracion2Substring = oracion2.Substring(5, oracion2.Length-5);        //toma apartir del quiton index character del string hacia la derecha, y hasta el numero de characteres del string menos los que ya se quitaron (para evitar overflow)
        Debug.Log("Primeros 5 caracteres con funcion substring: " + oracion2Substring);

        string[] oracion2Split = oracion2.Split('S');       //se parte en diferentes strings en un array pero no es ideal porque si se modifica el string hay que modificar el script del quinto caracter
        Debug.Log("Primeros 5 caracteres con funcion Split: " + oracion2Split[1]);      //print la segunda parte del array script (la 'S' delimita la particion del string en diferentes strings dentro del array
    }

    private void FixedUpdate()
    {
        //1)
        variable2 *= 1.1f;      // variable2 = variable2 * 1.1 flotante
        Debug.Log($"variable2 es = {variable2}");

        //3)
        variable6 = Random.Range(1, 30);
        variable7 = variable6 % 2;
        Color colorMod8GO1 = (variable7 == 0) ? Color.white : Color.black;
        GO1ParImpar.GetComponent<MeshRenderer>().material.color = colorMod8GO1;
            //(variable7 == 0) ? Debug.Log("Es par") : Debug.Log("Es impar");       no se puede poner este tipo de condicional/expresion? para evitar poner todo el if
        if (variable7 == 0)
        {
            Debug.Log($"El valor de {variable6} es par");
        }
        else
        {
            Debug.Log($"El valor de {variable6} es impar");
        }

        //4)
        GO2Color = GO2Colores[Random.Range(0, GO2Colores.Length)];      //genera numeros aleatorios de 0 a 4* y selecciona el valor guardado en la matriz GO2Colores dependiendo del numero aleatorio (posicion)
        Debug.Log($"El color de la esfera es {GO2Color}");
        switch (GO2Color)
        {
            case "azul":    //si GO2Color cayo en igual 0, se toma el valor de la matriz de posicion 0 que es igual a azul y entonces se cambia el color a blue
                GO2CaseColor.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case "rojo":
                GO2CaseColor.GetComponent<MeshRenderer>().material.color= Color.red;
                break;
            case "verde":
                GO2CaseColor.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case "negro":
                GO2CaseColor.GetComponent<MeshRenderer>().material.color = Color.black;
                break;

        }

    }
    // Update is called once per frame
    void Update()
    {
        //1)
        variable1++;        // variable1 = variable1 + 1
        Debug.Log($"variable1 es = {variable1}");
    }
}
