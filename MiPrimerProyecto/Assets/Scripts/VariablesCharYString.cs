using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesCharYString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char c = '9';
        int valorEntero = (int)char.GetNumericValue(c) + 5;
        int valorEntero2 = c - '3';
        int valorEntero3 = (int.Parse(c.ToString())) + 1;
        Debug.Log("c + 5 = " + valorEntero);
        Debug.Log("c - 3 = " + valorEntero2);
        Debug.Log("c + 1 = " + valorEntero3);
        Debug.Log("Se convierte en string si sumo char c + 1 = " + c + 1);

        int asciiValue = (int)c;
        Debug.Log("ASCII value of c is " + asciiValue);
        Debug.Log("ASCII value mas un uno " + ((int)c + 1));
        Debug.Log("En ASCII c + 1 = " + ((int)c + 1));

        char c2 = '\u0039';
        Debug.Log("En unicode el /u0039 es igual a " + c2);

        char c3 = 'm';
        int valorEntero4 = 0;
        if (!int.TryParse(c3.ToString(), out valorEntero4)) //TryParse regresea un TRUE o FALSE, como tengo ! si la condicion es FALSE entra al IF
        {
            Debug.LogError("Eso no es un tipo de dato valido"); //si c3 no es un numero entonces manda esto
        }
        Debug.Log("valorEntero4 = " + valorEntero4 + "(c3 si su valor es numerico o cero si es valor no numerico");

        int numeroDeCaracter = 12;
        char miCaracter;
        string miString = "Hola desde miString";
        miCaracter = miString[numeroDeCaracter];   //Se imprime el caracter numero #(numeroDeCarater) de izquierda a derecha empezando a contar desde cero hol"A" desd...
        Debug.Log("miString = " + miString);
        Debug.Log("El caracter numero " + numeroDeCaracter + " de miString es = "  + miCaracter);
        int longitud = miString.Length;
        Debug.Log("la longitud de miString es de " + longitud);
        
        string miString2 = miString.Replace("desde", "DESDE"); //se reemplaza parte de un string. Tambien se podria reemplazar un solo caracter para que los reemplace usando ' '
        Debug.Log(miString2);
        string miString3 = miString.Replace('e', 'E');
        Debug.Log(miString3);
        string miString4 = miString.ToUpper();
        Debug.Log(miString4);

        string miString5 = miString + " " + miString4; //concatenar los string (juntarlos)
        Debug.Log(miString5);
        
        string ejemploEscape = "C:\\Users\\Francisco\nDocumentos"; //se pone doble diagonal pero solo se imprime una. La diagonal invertida es caracter de escape. \n representa un salto de linea
        Debug.Log(ejemploEscape);

        string miNombre = "Francisco Javier";
        string misApellidos = "Fernandez Sanchez";
        string salidaNombres = $"Mi nombre es: {miNombre} y mis apellidos son {misApellidos}"; //se recomienda mas este tipo para no estar poniendo sumas y simplificar codigo. Con la opcion de comillas se vuelve mas complejo manejar los espacios en blanco
        string nombresSuma = "Mi nombre es: " + miNombre + " y mis apellidos son " + misApellidos;
        Debug.Log(salidaNombres);
        Debug.Log(nombresSuma);

        string primerApellido = misApellidos.Substring(0, 9); //empieza desde el primer caracter 0 hasta el caracter 9 = z
        Debug.Log(primerApellido);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
