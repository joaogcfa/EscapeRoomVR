using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarPuzzle : MonoBehaviour
{
    public GameObject objeto;
    private GameObject quebra;
    void Start()
    {
        quebra = GameObject.Find("Quebracabeca");
    }

    
    void OnCollisionEnter(Collision collision)
    {
        print(quebra.GetComponent<QuebraCabecas>().counter);
        if (collision.gameObject == objeto)
        {
            print(objeto.name);
            quebra.GetComponent<QuebraCabecas>().counter += 1;
        }
    }
        
    void OnCollisionExit(Collision collision)
    {
        print(quebra.GetComponent<QuebraCabecas>().counter);
        if (collision.gameObject == objeto)
        {
            print(objeto.name);
            quebra.GetComponent<QuebraCabecas>().counter -=1;
        }
    }
}
