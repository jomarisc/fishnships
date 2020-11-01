using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    //Currently loads the central hub. 
    //TODO: Open save menu to create a fresh save.
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    //TODO: Opens save menu to load a game.
    public void Continue()
    {
        Debug.Log("We are continuing! Not implemented yet!");
    }

    //TODO: Opens options.
    public void Options()
    {
        Debug.Log("Opening the options menu. Not implemented yet!");
    }

    //Exits game.
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quitting.");
    }
    
}
