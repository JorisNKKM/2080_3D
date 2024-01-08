using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public GameObject Square2;
    public float minX = -13.9f;
    public float avrX = -4.4f;
    public float maxX = 4.7f;

    public int cordY = 5;

    public float minZ = -13.9f;
    public float avrZ = -4.52f;
    public float maxZ = 5.02f;


    private GameManager gameManager;
    void Start()
    {
        gameManager = GetComponent<GameManager>();
        gameManager.Spawn2();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveUp();
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveDown();
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            gameManager.Spawn2();
        }
    }

    void MoveUp()
    {
        float z = Square2.transform.position.z;
        if (z == minZ)
        {
            Square2.transform.position = new Vector3(Square2.transform.position.x, Square2.transform.position.y, maxZ);
        }
        else if (z == avrZ)
        {
            Square2.transform.position = new Vector3(Square2.transform.position.x, Square2.transform.position.y, maxZ);
        }
    }
    void MoveDown()
    {
        float z = Square2.transform.position.z;
        if (z == avrZ)
        {
            Square2.transform.position = new Vector3(Square2.transform.position.x, Square2.transform.position.y, minZ);
        }
        else if (z == maxZ)
        {
            Square2.transform.position = new Vector3(Square2.transform.position.x, Square2.transform.position.y, minZ);
        }
    }
    void MoveLeft()
    {
        float x = Square2.transform.position.x;
        if (x == maxX)
        {
            Square2.transform.position = new Vector3(minX, Square2.transform.position.y, Square2.transform.position.z);
        }
        else if (x == avrX)
        {
            Square2.transform.position = new Vector3(minX, Square2.transform.position.y, Square2.transform.position.z);
        }
    }

    void MoveRight()
    {
        float x = Square2.transform.position.x;
        if (x == minX)
        {
            Square2.transform.position = new Vector3(maxX, Square2.transform.position.y, Square2.transform.position.z);
        }
        else if (x == avrX)
        {
            Square2.transform.position = new Vector3(maxX, Square2.transform.position.y, Square2.transform.position.z);
        }
    }



    
}
