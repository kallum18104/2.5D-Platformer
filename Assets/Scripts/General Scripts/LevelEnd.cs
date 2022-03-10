using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") //if something collides with this object, it will check if it's tagged with Player and then will add one to the scene number, loading the next scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
