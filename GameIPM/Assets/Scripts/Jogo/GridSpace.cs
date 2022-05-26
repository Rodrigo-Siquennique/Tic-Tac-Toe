using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    
    public Button button;
    public Text buttonText;
    public GameObject cross;
    public GameObject skull;

    private GameController gameController;


    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }

    public void SetSpace()
    {
        if (gameController.playerMove == true)
        {

            buttonText.text = gameController.GetPlayerSide();
            if (buttonText.text == "X")
            {

                cross.SetActive(true);
            } 

            if (buttonText.text == "O")
            {

                skull.SetActive(true);
            }

            
            button.interactable = false;
            gameController.EndTurn();
            
        }
    }

    private void Update()
    {

        if (buttonText.text == "X")
        {
           
            cross.SetActive(true);
        }

        if (buttonText.text == "O")
        {
          
            skull.SetActive(true);
        }

       if (buttonText.text == "")
        {
            cross.SetActive(false);
            skull.SetActive(false);
        } 
    }


}
