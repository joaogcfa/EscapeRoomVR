using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Inicia()
    {
        SceneManager.LoadScene("EscapeRoom");

    }
    public void quit()
    {
        Application.Quit();
    }
}
