using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2Spawn : MonoBehaviour
{
     private float frequency = 5f;
     public GameObject objectToSpawn;
     private Vector3 spawnPosition = new Vector3(70.79749f, 105f, 1.237597f);

    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, frequency);
    }

    void SpawnObject()
    {
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }

}
