using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Spawn spawnScript;

    void Start()
    {
        spawnScript = GetComponent<Spawn>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S)|| Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.D)) 
        {
            spawnScript.Spawn2();
        }
    }
}
