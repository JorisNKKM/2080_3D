using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyButton : MonoBehaviour
{
    public GameObject Easy;
    public DifficultyMiddleman difficulty;

    public void OnMouseUp()
    {

        SceneManager.LoadScene("Main");
        print("woks");
        After();


    }
    public void After()
    {
        difficulty.Easy();
    }
}
