using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BotaoDialogic : MonoBehaviour
{
    public TextMeshPro textMesh;
    public string fases;
    public int contador;
    public void Start(){
        GameObject textoRespostaDia = GameObject.Find("textoRespostaDia");
        textMesh = textoRespostaDia.GetComponent<TextMeshPro>();
    }
    public void Apertar(string momento){
        print(momento);
        fases += momento;
        print(fases);
        print(contador);
        contador += 1;
        if(contador > 2){
            if (fases.Trim().Equals("NoiteTardeDia")) {
                SetText("6");
                fases = "";
                contador = 0;
            }
            else
            {   

                fases = "";
                contador = 0;
            }
        }

    }
    public void SetText(string text)
    {
        textMesh.text = text;
    }
}
