using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BotaoDialogic : MonoBehaviour
{
    public TextMeshPro textMesh;
    public string fases;
    public int contador;
    public GameObject Quebracabeca;
    public Material Material;
    public void Start(){
        GameObject textoRespostaDia = GameObject.Find("textoRespostaDia");
        textMesh = textoRespostaDia.GetComponent<TextMeshPro>();
        // GameObject Quebracabeca = GameObject.Find("Quebracabeca");
        Quebracabeca.SetActive(false);
    }
    public void Apertar(string momento){
        print(momento);
        fases += momento;
        print(fases);
        print(contador);
        contador += 1;
        if(contador > 2){
            if (fases.Trim().Equals("NoiteTardeDia")) {
                Quebracabeca.SetActive(true);
                SetText("6");
                fases = "";
               contador = 0;
            }
            else
            {
                StartCoroutine(funcao());
                fases = "";
                contador = 0;
            }
        }


    }
    public void SetText(string text)
    {
        textMesh.text = text;
    }

    IEnumerator funcao()
    {
        yield return new WaitForSeconds(5/10);
        for(int i = 0; i < 3; i++)
        {
            GameObject child = transform.GetChild(i).gameObject;
            child.GetComponent<Renderer>().material = Material;
        }
    }
}
