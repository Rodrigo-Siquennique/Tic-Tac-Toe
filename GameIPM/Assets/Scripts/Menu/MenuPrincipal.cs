using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public string menu = "Menu";
    public string game = "Jogo";
    public string options = "Opções";
    public string tutorial = "Tutorial";

    public void Play()
    {
        SceneManager.LoadScene(game);
    }

    public void Tutotial()
    {
        SceneManager.LoadScene(tutorial);
    }

    public void Options()
    {
        SceneManager.LoadScene(options);
    }

    public void Menu()
    {
        SceneManager.LoadScene(menu);
    }

    public void Quit()
    {
        Debug.Log("Exiting...");
        Application.Quit();
    }
}