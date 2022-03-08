using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonLogic : MonoBehaviour
{
    public TextMeshPro textMesh;
    public string numeros;
    public string resposta = "465";
    public void Start(){
        GameObject textoSenha = GameObject.Find("TextoSenha");
        textMesh = textoSenha.GetComponent<TextMeshPro>();
    }
    public void Apertar(int numero){
        numeros += numero.ToString();
        SetText(numeros);
        print(numeros);
        if(numeros.Length > 2){
            if (numeros.Trim().Equals("465")) {
                print("ganhou!");
                numeros = "";
            }
            else
            {   
                numeros = "";
            }
        }

    }
    public void SetText(string text)
    {
        textMesh.text = text;
    }
}
