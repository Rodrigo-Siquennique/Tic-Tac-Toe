using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    
    public string Tutorial = "Tutorial";

    public void Play()
    {
        SceneManager.LoadScene(Tutorial);
    }

    public void Quit()
    {
        Debug.Log("Exiting...");
        Application.Quit();
    }
}