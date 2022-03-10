using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class randomLevel : MonoBehaviour
{
    // Start is called before the first frame update

    public void randomlevel()
    {
        int index = Random.Range(2, 6); //sets an array of the scenes.
        SceneManager.LoadScene(index); //picks a random one.
    }

}
