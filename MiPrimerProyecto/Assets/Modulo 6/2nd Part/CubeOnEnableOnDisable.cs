using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnableOnDisable : MonoBehaviour
{
    public GameObject CuboInEnableDisable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        private void OnEnable()
    {
        GameObject cuboenable = Instantiate<GameObject>(CuboInEnableDisable);
        cuboenable.transform.position = new Vector3(-2, 8, 2);
        cuboenable.name = "Cubo Spawneado desde Enable";
        cuboenable.GetComponent<MeshRenderer>().material.color = Color.magenta;
    }

    private void OnDisable()
    {
        GameObject cubodisable = Instantiate<GameObject>(CuboInEnableDisable);
        cubodisable.transform.position = new Vector3(-2, 8, 2);
        cubodisable.name = "Cubo Spawneado desde Disable";
        cubodisable.GetComponent<MeshRenderer>().material.color= Color.yellow;
    }
}
