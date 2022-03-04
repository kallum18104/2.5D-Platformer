using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreen : MonoBehaviour
{
    public bool isFinished = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        rotateCube.isRotated = false;

    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("quit game!");
    }

    public void exitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void rick()
    {
        SceneManager.LoadScene("Rick");
    }
}
