using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;

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
