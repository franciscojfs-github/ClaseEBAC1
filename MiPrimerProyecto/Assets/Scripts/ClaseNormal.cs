using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseNormal
{
    int numero1;
    int numero2;

    public ClaseNormal(int param1, int param2)        //constructor. le podemos pedir que se le pasen dos numeros, y que sin estos dos numeros no va poder ser creado
    {
        numero1 = param1;
        numero2 = param2;
    }

    public ClaseNormal(float param1, float param2)      //sobrecarga de constructor. por si en el otro string desde el que se llama esta usando valores float
    {
        numero1 = (int)param1;      //se hace un casteo
        numero2 = (int)param2;
    }

    public int SumarEnteros(int a, int b)
    { 
        return a + b; 
    }

    public float SumarFlotantes2(float a, float b)     //se hace de nuevo una sobrecarga por si desde el script Clases se llama a la funcion SumarEnteros pero se llama desde alla con numeros tipo float en vez de enteros
    { 
        return a + b; 
    }

    //estatica(no instancia)
    public static float MultiplicarFlotantes(float a, float b)
    {
        return a * b;
    }
}
