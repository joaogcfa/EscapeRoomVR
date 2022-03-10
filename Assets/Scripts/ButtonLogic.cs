using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ButtonLogic : MonoBehaviour
{
    public GameObject Porta;
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
                Porta.SetActive(false);
                Time.deltaTime(5000);
                SceneManager.LoadScene("menu");
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
