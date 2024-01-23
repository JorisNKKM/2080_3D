using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMusic : MonoBehaviour
{
    public AudioSource Track1;
    public AudioSource Track2;
    public AudioSource Track3;
    public AudioSource Track4;
    public bool isPlaying;
    public void Start()
    {

        int rnd = Random.Range(1, 4);
        if (rnd == 1)
        {
            Track1.Play();
        }
        if (rnd == 2) 
        {
            Track2.Play();
        }
        if (rnd == 3)
        {
            Track3.Play();
        }
        if (rnd == 4)
        {
            Track4.Play();
        }
        isPlaying=true;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&& isPlaying==true)
        {
            Track1.Stop();
            Track2.Stop();
            Track3.Stop();
            Track4.Stop();
            isPlaying=false;
        }
        if (Input.GetKeyDown(KeyCode.E) && isPlaying == false)
        {
            Start();
        }

    }


}
