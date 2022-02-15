using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScript : health
{
    public bool isDead;
    public GameObject deathUI;
    public GameObject player;
    public GameObject Timer;
    public GameObject DeathCamera;
    void Start()
    {
        playerHealth = 100;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision Player)
    {

        //sets players health to 0 when falls to the collider.
        playerHealth = 0;
    }

    void Update()
    {
        if (playerHealth == 0)
        {
           //This code is all executed when you die.
            isDead = true;
            Timer.SetActive(false);
            player.SetActive(false);
            deathUI.SetActive(true);
            DeathCamera.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void restartLevel()
    {

        //Reloads the active level.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void exitToMenu()
    {
        //Loads the main menu scene
        SceneManager.LoadScene("MainMenu");
    }

}
