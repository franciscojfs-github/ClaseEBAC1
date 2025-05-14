using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;

public class EstructurasDeDatos : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();       // el signo <> denota que es un generico.
    List<string> listaStrings = new List<string>();
    HashSet<int> hashSetInts = new HashSet<int>();      //no es posible ordenar. los elementos del HashSet son unicos, no se pueden repetir. Es mas optimo/rapidos que la Lista.
    Queue<string> colaStrings = new Queue<string>();
    Stack <string> pilaString = new Stack<string>();
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();     //colecciones de datos que estan dados por el par: llave, valor. El primer tipo de dato es la llave, con el cual voy a buscar a que valor esta relacionado. El valor puede ser nulo, no existir, pero la llave tiene que forzozamente existir 

    // Start is called before the first frame update
    void Start()
    {
        DemoDiccionario("escopeta");
        DemoDiccionario("espada");
        DemoListas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DemoListas()
    {
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0, 21));
        }
        foreach (var numero in listaNumeros)        //var se podria reemplazar por int.
        {
            Debug.Log(numero);
        }
        
        listaNumeros.Sort();                    //acomoda/arregla los elementos de una lista
        foreach (var numero in listaNumeros)
        {
            Debug.Log($"La lista en orden sencillo: {numero}");
        }

        //agregando linQ                                              //se puede usar "var" porque no lo estamos definiendo hasta arriba en public class etc : etc {}; es temporal porque se crea solo en este metodo DemoListas
        var listaOrdenada = listaNumeros.OrderBy(p => p).ToList();      //ordenar en base a ese parametro. por ejemplo ordenar armadura por durabilidad p => p.durabilidad. La "p" es el valor de cada elemento de la lista
        var listaConValoresGrandes = listaNumeros.Where(p => p > 10).ToList();
        //foreach (var numero in listaNumeros)
        //{
        //    Debug.Log(numero);
        //}
        Debug.Log("lista ordenada con linQ");
        foreach (var numero in listaOrdenada)
        {
            Debug.Log(numero);
        }
        Debug.Log("lista ordenada con linQ numeros grandes");
        foreach (var numero in listaConValoresGrandes)
        {
            Debug.Log(numero);
        }

        listaStrings.Add("Francisco");
        listaStrings.Add("Ivonne");
        listaStrings.Add("Abigail");
        listaStrings.Add("Flavia");
        listaStrings.Add("Domenica");
        foreach (var nombre in listaStrings)        //var se puede reemplazar por string. por cada variable en listaStrings haz lo siguiente con la var nombre
        {
            Debug.Log(nombre);
        }

        listaStrings.Remove("Flavia");          //quita de la lista
        listaStrings.RemoveAt(3);               //quita de la lista un var que se encuentra en (3). Empieza a contar desde (0) = Francisco. Como se quito a Flavia, ahora la lista va de 0 a 3 y por lo tanto 3 = Domenica
        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
    }
    

    public void DemoHashSets()
    {
        for (int i = 0; i < 21; i++)
        {
            hashSetInts.Add(i);
        }
        if (hashSetInts.Contains(5))
        {
            hashSetInts.Remove(5);
        }
        else
        {
            Debug.Log("El HashSet no contiene este elemento");
        }
        foreach (int value in hashSetInts)
        {
            Debug.Log(value);
        }
    }
    

    public void DemoColas()
    {
        ///FIFO: First In, First Out
        colaStrings.Enqueue("Proyectil 1");
        colaStrings.Enqueue("Proyectil 2");
        colaStrings.Enqueue("Proyectil 3");
        colaStrings.Enqueue("Proyectil 4");
        colaStrings.Enqueue("Proyectil 5");
        Debug.Log(colaStrings.Peek());      //muestra proyectil 1
        colaStrings.Dequeue();              //quita el primer proyectil
        Debug.Log(colaStrings.Peek());      //mostrara proyectil 2
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
    }

    public void DemoPilas()
    {
        ///FILO: First In, Last Out
        pilaString.Push("As");
        pilaString.Push("CincoEspadas");
        pilaString.Push("TresCorazones");
        pilaString.Push("CuatroTrebol");
        pilaString.Push("ReyEspadas");
        Debug.Log(pilaString.Peek());       //sale primero el rey de espadas (el ultimo en entrar, como si fuera una baraja caraja)
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
    }

    public void DemoDiccionario(string arma)        //le pasamos un valor "arma" como parametro. Y luego haremos el TryGetValue con el "arma" mas abajo en el codigo
    {
        float temporal;
        if (!poderArmas.ContainsKey("rifle"))       //se agregan los if porque: La primera vez que se llama a esta funcion alla arriba "DemoDiccionario("escopeta");" se agregan los strings (rifle, pistola, etc.)
        {                                           //pero luego se vuelve a llamar en "DemoDiccionario("espada");" y se tratan de volver a aregar esos strings/valores (rifle, pistola, etc.)
            poderArmas.Add("rifle", 7.0f);          //entonces se agrega un condicional para checar si ya estan agregados que no se agreguen. No se pueden agregar si tienen el mismo nombre probablemente
        }
        if (!poderArmas.ContainsKey("pistola"))
        {
            poderArmas.Add("pistola", 3.0f);
        }
        if (!poderArmas.ContainsKey("escopeta"))
        {
            poderArmas.Add("escopeta", 5.0f);
        }
        if (!poderArmas.ContainsKey("rifleFrancotirador"))
        {
            poderArmas.Add("rifleFrancotirador", 10.0f);
        }
        if (!poderArmas.ContainsKey("cuchillo"))
        {
            poderArmas.Add("cuchillo", 2.0f);
        }
        //Debug.Log(poderArmas["escopeta"]);      //se escribe la llave y regresa el valor. Si el valor que escribimos entre corchetes no existe arroja una excepcion (error). Por lo tanto se puede hacer con .TryValue

        if (poderArmas.TryGetValue(arma, out temporal))       //si no tuviera el TryGetValue y no existiera la palabra entonces arrojaria error
        {
            Debug.Log($"El arma: {arma} hace dano de: " + temporal);
        }
        else
        {
            Debug.Log("Esa arma no existe: " + arma);
        }
    }
}
