using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlatform : MonoBehaviour
{
    public GameObject platformPathStart;
    public GameObject platformPathEnd;
    public int speed;
    private Vector3 startPosition;
    private Vector3 endPosition;

    void Start()
    {
        startPosition = platformPathStart.transform.position;  //sets the start position variable of the script to be an empty object specified.
        endPosition = platformPathEnd.transform.position;  //sets the end position variable of the script to be an empty object specified.
        StartCoroutine(Vector3LerpCoroutine(gameObject, endPosition, speed)); //starts sending the platform from the start position to the end position at a specified speed.
    }

    void Update()
    {
        if (transform.position == endPosition)
        {
            StartCoroutine(Vector3LerpCoroutine(gameObject, startPosition, speed)); //if the platform reaches the end position, it will set out for the start position at a specified speed.
        }
        if (transform.position == startPosition)
        {
            StartCoroutine(Vector3LerpCoroutine(gameObject, endPosition, speed)); //if the platform reaches the start position, it will set out for the end position at a specified speed.
        }

        
    }

    IEnumerator Vector3LerpCoroutine(GameObject obj, Vector3 target, float speed)
    {
       
        Vector3 startPosition = obj.transform.position;
        float time = 0f;

        while (obj.transform.position != target)
        {
            obj.transform.position = Vector3.Lerp(startPosition, target, (time / Vector3.Distance(startPosition, target)) * speed);
            time += Time.deltaTime;
            yield return null;

            //this simply sets it so that when the platform isn't at the same transform as the target, it will move torwards the target.
        }
    }

    void OnCollisionEnter(Collision Player)
    {
        Player.gameObject.transform.SetParent(gameObject.transform, true);
        //when the player is on the platform, the player becomes a child of the platform.
    }

    void OnCollisionExit(Collision Player)
    {
        Player.gameObject.transform.parent = null;
        //when the player goes off the platform, it is no longer a child of the platform.
    }
}
