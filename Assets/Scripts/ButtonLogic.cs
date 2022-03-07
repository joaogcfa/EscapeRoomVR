using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonLogic : MonoBehaviour
{
    public TextMeshPro textMesh;
    public string numeros;
    public string resposta = "4652";
    public void Start(){
        GameObject textoSenha = GameObject.Find("TextoSenha");
        textMesh = textoSenha.GetComponent<TextMeshPro>();
    }
    public void Apertar(int numero){
        numeros += numero.ToString();
        SetText(numeros);
        print(numeros);
        if(numeros.Length > 3){
            print(numeros.Trim());
            if (numeros.Trim().Equals("4652")) {
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
    void Teste(){
        print("Passou no teste");
    }
}
