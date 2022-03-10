using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{

    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 200f;

    [SerializeField] private Transform levelPart_Start;
    [SerializeField] private List<Transform> levelPartList;
    [SerializeField] private playerScript player;

    private Vector3 lastEndPosition;

    private void Awake()
    {
        lastEndPosition = levelPart_Start.Find("endPosition").position; //sets the Vector3 lastEndPosition to be an empty thats set on all the prefabs called "endPosition"

        int startingSpawnLevelParts = 5; //when loaded in, 5 prefabs will be generated instantly.
        for (int i = 0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
            //calls the SpawnLevelPart function 5 times.
        }
    }

    private void Update()
    {
        if (Vector3.Distance(player.GetPosition(), lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            // Spawn another level part when the player is close enough to the end position.
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("endPosition").position;
        //starts a funtion that spawns a prefab out of a list that is predefined, then spawns the prefab at the endPosition of the furthest one,
        //then setting the endPosition to be the new one on the new prefab spawned.
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
        //spawns new level part.
    }

}
