using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public TextMeshPro textMesh;
    public string numeros;
    public string resposta = "4";
    public void Start(){
        GameObject textoSenha = GameObject.Find("TextoTarget");
        textMesh = textoSenha.GetComponent<TextMeshPro>();
    }
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Target")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            SetText(resposta);
        }
    }
    public void SetText(string text)
    {
        textMesh.text = text;
    }
}
