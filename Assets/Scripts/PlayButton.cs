using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject play;

    public double xPos = -11.92578;
    public int yUp = 42;
    public int yDown = 41;
    public int zPos = 0;

    private void OnMouseDown()
    {
        play.transform.position = new Vector3((float)xPos, yDown, zPos);
        
    }
    private void OnMouseUp()
    {
        play.transform.position = new Vector3((float)xPos, yUp, zPos);
        SceneManager.LoadScene("Main");
    }
}
