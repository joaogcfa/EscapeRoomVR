using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuebraCabecas : MonoBehaviour
{
    public TextMeshPro textMesh;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        GameObject textoSenha = GameObject.Find("TextoPuzzle");
        textMesh = textoSenha.GetComponent<TextMeshPro>();
        counter = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > 2){
            SetText("5");
        }
    }
    public void SetText(string text)
    {
        textMesh.text = text;
    }
}
