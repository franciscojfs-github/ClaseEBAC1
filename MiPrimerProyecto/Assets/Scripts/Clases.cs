using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clases : MonoBehaviour     //contiene toda la logica de unity orientada a objetos. permite llamar a la funcion de Start, Update, etc. pero no siempre necesitamos esta herencia en particular.
{
    // tenemos primero los campos, despues las funciones de unity, despues las funciones hechas por nosotros, y despues las propiedades
    /// <summary>
    /// campos (por defecto todo se inicia como privado si no se especifica)
    /// </summary>
    public float campo1;            //cualquier clase que exista en nuestro codigo podra verla. public o private son modificadores de acceso
    private bool campo2;            //unicamente esta clase puede tener acceso a este dato. Ninguna otra clase podra ver esto desde donde estan ellos. Esto se define como el alcance.
    protected float campo3 = 5;     //unicamente sus clases hijos podran ver (herencia)
    public float campo4 = 4;        //usualmente las variables empiezan con miniscula y palabra que se agregue tendra mayuscula
    
    /// <summary>
    /// funciones de unity
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        
        campo1 = SumaFlotantes1(campo3, campo4);        //la funcion SumaFlotantes1 esta definida en este script y se puede mandar a llamar asi facilmente
        Debug.Log(campo1);
        VuelveCeroAlNumero(out campo1);     //no estoy diciendo que alguna variable va a ser igual a lo que me retorne la funcion. esta funcion no retorna un valor. 
        Debug.Log(campo1);
        
        //llamando al script ClaseNormal
        //ClaseNormal miclase = new ClaseNormal(campo3, campo4);      //marca error porque campo3 y campo4 son flotantes. En el script de ClaseNormal (un script publico que se creo por aparte) indica que los paramaetros son tipo int. Se puede hacer una sobrecarga de valores para que funcione y agregar en en ClaseNormal script que ClaseNormal tambien es para float
        ClaseNormal miClase = new ClaseNormal(campo3, campo4);      //se creo un nuevo objeto de tipo ClaseNormal que se llama miClase
        campo1 = miClase.SumarFlotantes2(campo3, campo4);            //se utilizo un metodo (sumarFlotantes) dentro de esa instancia (miClase)
                                                                    // Para llamar a sumarFlotantes tuve que crear una instancia de la clase (miClase) o en otras palabras tuve que crear un objeto
                                                                    //Esto no es una funcion estatica. Una funcion estatica es una funcion que no requiere una instancia. 

        // Una funcion estatica (sin crear una estancia)
        Debug.Log(campo1);
        campo1 = ClaseNormal.MultiplicarFlotantes(campo3, campo4);      //cuando escribimos el "." el autocompletar ya nos sugiere .MultiplicarFlotates que ya es una variable estatica. Pero esto no pasa si borramos el punto en miClase.SumarFlotantes2 porque Multiplicar es estatica y miClase. es para los metodos que necesitan ser instanciados
        Debug.Log(campo1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// <summary>
    /// funciones propias
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>

    public float SumaFlotantes1(float a, float b)        //funcion publica + va retornar un valor de float + el nombre de nuestra funcion (la segunda palabra). Se inica con mayuscula y nueva palabra empieza con Mayuscula. Entre parentesis el parametro de nuestra funcion.
    {
        return a + b;
    }

    public void VuelveCeroAlNumero(out float numero)    //esta funcion no retorna un valor (no modifica VuelveCeroAlNumero). out = cualquier cosa que entre a esta funcion con esta palabra va a ser modificada dentro de la funcion; por lo tanto no hay que regresarla, ya esta siendo modificada
    {
        numero = 0;
    }
    /// <summary>
    /// propiedades
    /// </summary>
    public int propiedad1 { get; set; }         //las propiedas son una variable pero tienen metodos accesores (get = el valor que tiene guardada esta variable; set = escribir en su contenido ). Tienes que poner que sea publica si no no se podra hacer uso de esta propiedad
                                                //los campos son privados y las propiedades publicas; para que asi solo se puedan modificar lo que uno quiere (lo que esta en propiedades), sin modificar accidentalmente el codigo que esta en clase                        
    public bool propiedad2 { get; set; }        //en la propiedad podemos selectivamente seleccionar que si y que no se va modificar para tener mejor control

    public float propiedadSoloLectura { get; }
}



