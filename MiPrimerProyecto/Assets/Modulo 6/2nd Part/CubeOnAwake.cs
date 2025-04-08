using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOnAwake : MonoBehaviour
{
    public GameObject CuboInAwake;

    private void Awake()
    {
        GameObject cuboawake = Instantiate<GameObject>(CuboInAwake);
        cuboawake.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        cuboawake.transform.position = new Vector3(2, 8, 2);
        cuboawake.name = "Cubo Spawneado desde Awake";

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
