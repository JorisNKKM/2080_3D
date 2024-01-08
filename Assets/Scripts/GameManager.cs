using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Square2;
    public float minX = -13.9f;
    public float avrX = -4.4f;
    public float maxX = 4.7f;

    public int cordY = 5;

    public float minZ = -13.9f;
    public float avrZ = -4.52f;
    public float maxZ = 5.02f;
    public void Spawn2()
    {
        int randomSpawn = Random.Range(1, 9);
        if (randomSpawn == 1)
        {
            Square2.transform.position = new Vector3(minX, cordY, minZ);
        }
        if (randomSpawn == 2)
        {
            Square2.transform.position = new Vector3(avrX, cordY, minZ);
        }
        if (randomSpawn == 3)
        {
            Square2.transform.position = new Vector3(maxX, cordY, minZ);
        }
        if (randomSpawn == 4)
        {
            Square2.transform.position = new Vector3(minX, cordY, avrZ);
        }
        if (randomSpawn == 5)
        {
            Square2.transform.position = new Vector3(avrX, cordY, avrZ);
        }
        if (randomSpawn == 6)
        {
            Square2.transform.position = new Vector3(maxX, cordY, avrZ);
        }
        if (randomSpawn == 7)
        {
            Square2.transform.position = new Vector3(minX, cordY, maxZ);
        }
        if (randomSpawn == 8)
        {
            Square2.transform.position = new Vector3(avrX, cordY, maxZ);
        }
        if (randomSpawn == 9)
        {
            Square2.transform.position = new Vector3(maxX, cordY, maxZ);
        }

    }
}
