using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public AudioSource lose;
    private void OnTriggerEnter(Collider other)
    {
        lose.Play();

        StartCoroutine(LoadSceneAfterDelay(2.5f));
    }


    private IEnumerator LoadSceneAfterDelay(float delay)
    {
        
        yield return new WaitForSeconds(delay);

        
        SceneManager.LoadScene("1");
    }
}
