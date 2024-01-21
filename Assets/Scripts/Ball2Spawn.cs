using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2Spawn : MonoBehaviour
{
     private float frequency = 5f;
     public GameObject objectToSpawn;

    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, frequency);
    }

    void SpawnObject()
    {
        int addX=Random.Range(-10, 10);
        int addZ = Random.Range(-10, 10);
        Vector3 spawnPosition = new Vector3(70.79749f+ addX, 110f, 1.237597f+ addZ);
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
    

}
