using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject SettingsMenu;
    public static bool isPaused;
    public bool isMute;
    public deathScript death;

    void Start()
    {
        PauseMenu.SetActive(false);
        SettingsMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!death.isDead)
            {
                if (isPaused)
                {
                    resumeGame();
                    turnOffSettings();
                }
                else
                {
                    pauseGame();
                }
            }
            
            
        }
    }

    public void pauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void resumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void exitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void settingsMenu()
    {
        PauseMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }

    public void backButton()
    {
        PauseMenu.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    public void turnOffSettings()
    {
        SettingsMenu.SetActive(false);
    }

    public void mute()
    {
        isMute = !isMute;
            AudioListener.volume = isMute ? 0 : 1;
    }
}
