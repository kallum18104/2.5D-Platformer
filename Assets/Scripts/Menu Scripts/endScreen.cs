using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreen : MonoBehaviour
{
    public bool isFinished = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; //removes cursor restrictions
        rotateCube.isRotated = false; //sets the isRotated to false, this caused an issue where since you had been rotated before, you would dash off the front of the platform.

    }

    public void quitGame()
    {
        Application.Quit(); //quits the game.
        Debug.Log("quit game!"); //tells the debug log that the game has been quit.
    }

    public void exitToMenu()
    {
        SceneManager.LoadScene("MainMenu"); //loads the main menu.
    }

}
