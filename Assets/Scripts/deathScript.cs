using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScript : MonoBehaviour
{
    public bool isDead;
    public GameObject deathUI;
    public GameObject player;
    public GameObject Timer;
    public GameObject DeathCamera;
    public string leveltoLoad;
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision Player)
    {
        isDead = true;
    }

    void Update()
    {
        if (isDead == true)
        {
            Timer.SetActive(false);
            player.SetActive(false);
            deathUI.SetActive(true);
            DeathCamera.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(leveltoLoad);
    }

    public void exitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
