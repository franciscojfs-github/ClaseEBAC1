using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOnUpdate : MonoBehaviour
{
    public GameObject CuboInUpdate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cuboupdate = Instantiate<GameObject>(CuboInUpdate);
        cuboupdate.name = "Cubo Spawneado desde Update";
        cuboupdate.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        cuboupdate.transform.position = new Vector3(-10, 1, 1);
    }
}
