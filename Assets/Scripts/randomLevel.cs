using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class randomLevel : MonoBehaviour
{
    // Start is called before the first frame update

    public void randomlevel()
    {
        int index = Random.Range(2, 4);
        SceneManager.LoadScene(index);
    }

}
