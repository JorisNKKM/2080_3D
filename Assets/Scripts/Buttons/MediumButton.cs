using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Medium : MonoBehaviour
{
    public GameObject Medium_;
    public DifficultyMiddleman difficulty;

    public void OnMouseUp()
    {
        SceneManager.LoadScene("Main");
        //After();
    }
    
}
