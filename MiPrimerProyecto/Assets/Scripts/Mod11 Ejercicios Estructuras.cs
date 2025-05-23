using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Mod11EjerciciosEstructuras : MonoBehaviour
{
    int x = 5;
    int y = 0;
    int z = 9;
    // Start is called before the first frame update
    void Start()
    {
        //1 Crear una funcion de una lista de tamano X que guarde numeros aleatorios entre limites inferior y superior
        FuncionLista(x, y, z);      //tamano de lista, limite inferior, limite superior

        //2 Una funcion que reciba como entrada un arreglo de enteros y regrese un arreglo igual pero ordenados en descendente
        int[] arregloInicial = { 3, 7, 1, 5 };
        Debug.Log($"El arreglo sin ordenar es {string.Join(", ", arregloInicial)}");
        FuncionArregloDescendente(arregloInicial);

        //3
        List<int> listaLLena = new List<int> { 4, 4, 3, 3, 9, 5, 3, 7, 8, 7, 0 };
        Debug.Log($"La lista que se van convertir en hashSet es {string.Join(", ", listaLLena)}");
        FuncionHashset(listaLLena);

        //return ejemplo
        HashSet<int> salida = FuncionHashset2(listaLLena);
        foreach(int i in salida)
        {
            Debug.Log($"El hashset con return es {i}");
        }
    }

    public void FuncionLista(int tamano, int limiteInferior, int limiteSuperior)
    {
        //1
        List<int> listaAleatoria = new List<int>(tamano);      //se crea la lista de tamano = tamano
        for (int i = 0; i < tamano; i++)    //para llenar cada valor de la lista
        {
            int numeroAleatorio = Random.Range(limiteInferior, limiteSuperior);     //crea numeros aleatorios
            listaAleatoria.Add(numeroAleatorio);    //guarda los numeros aleatorios en la lista
            Debug.Log($"{x} Numeros aleatorios entre {y} y {z} son {listaAleatoria[i]}");
        }
    }

    //2
    public void FuncionArregloDescendente(int[] arregloSalida)
    {
        List<int> listaAOrdenar = arregloSalida.ToList();      //guarda el arreglo de entrada en una lista
        listaAOrdenar = listaAOrdenar.OrderByDescending(p => p).ToList();       //ordena la lista por numero descendiente
        int tamanoLista = listaAOrdenar.Count;      //guarda el tamano de la lista
        arregloSalida = listaAOrdenar.ToArray();    //convierte la lista ordenada en arreglo nuevamente
        for (int i = 0; i < tamanoLista; i++)    //ciclo para imprimir desde el primer item del arreglo hasta su ultimo
        {
            Debug.Log("El arreglo de mayor a menor: " + arregloSalida[i]);
        }
    }

    //3
    public void FuncionHashset(List<int> lista)
    {
        HashSet<int> hashsetSalida = lista.ToHashSet();
        foreach (int i in hashsetSalida)
        {
            Debug.Log($"El hashSet con numeros sin repetir: {i}");
        }
    }

    //return ejemplo
    public HashSet<int> FuncionHashset2(List<int> lista)
    {
        HashSet<int> hashsetSalida = lista.ToHashSet();
        return hashsetSalida;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
