using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject sphere;
    private Vector3 spawnPoint = new Vector3(0, 7, 0);

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn,spawnPoint, Quaternion.Euler(53,7,12));
        }
            
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(sphere, spawnPoint, Quaternion.Euler(53, 7, 12));
        }

        
    }
}
