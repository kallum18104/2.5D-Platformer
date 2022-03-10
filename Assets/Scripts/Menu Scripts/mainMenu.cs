using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    public GameObject SettingsMenu;
    public GameObject MainMenu;
    public bool isMute;

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //adds one to the index, loading the first level.
    }

    public void endless()
    {
        SceneManager.LoadScene("Endless"); //loads the endless mode.
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("quit game!");
    }

    public void settingsMenu()
    {
        SettingsMenu.SetActive(true);
        MainMenu.SetActive(false);

    }

    public void backButton()
    {
        SettingsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }




}
