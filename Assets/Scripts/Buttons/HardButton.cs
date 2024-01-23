using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardButton : MonoBehaviour
{
    public GameObject Hard;
    public DifficultyMiddleman difficulty;

    public void OnMouseUp()
    {
        SceneManager.LoadScene("Main");
        //After();
    }
    
}
