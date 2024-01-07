using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public GameObject Square2;

    void Start()
    {
        Spawn2();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveUp();
        }
        
    }

    void MoveUp()
    {
        //i want to make if's if Square2 is z cord -13.9f then transform its position to z cord  -4.52f, or if its z cord  -4.52f then make it 5.02f, if it's 5.02f don,t change it. The problem is i don't have the game object position in all times, can u help with that?
    }

    void Spawn2()
    {
        int randomSpawn = Random.Range(1, 9);
        if (randomSpawn==1)
        {
            Square2.transform.position= new Vector3(-13.9f, 5, -13.9f);
        }
        if (randomSpawn == 2)
        {
            Square2.transform.position = new Vector3(-4.4f, 5, -13.9f);
        }
        if (randomSpawn == 3)
        {
            Square2.transform.position = new Vector3(4.7f, 5, -13.9f);
        }
        if (randomSpawn == 4)
        {
            Square2.transform.position = new Vector3(-13.9f, 5, -4.52f);
        }
        if (randomSpawn == 5)
        {
            Square2.transform.position = new Vector3(-4.4f, 5, -4.52f);
        }
        if (randomSpawn == 6)
        {
            Square2.transform.position = new Vector3(4.7f, 5, -4.52f);
        }
        if (randomSpawn == 7)
        {
            Square2.transform.position = new Vector3(-13.9f, 5, 5.02f);
        }
        if (randomSpawn == 8)
        {
            Square2.transform.position = new Vector3(-4.4f, 5, 5.02f);
        }
        if (randomSpawn == 9)
        {
            Square2.transform.position = new Vector3(4.7f, 5, 5.02f);
        }
        
    }
}
