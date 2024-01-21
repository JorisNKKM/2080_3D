using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyButton : MonoBehaviour
{
    public GameObject Easy;
    public int diff;

    public void OnMouseUp()
    {
        print("works");
        SceneManager.LoadScene("Main");
        diff = 0;
    }
}
