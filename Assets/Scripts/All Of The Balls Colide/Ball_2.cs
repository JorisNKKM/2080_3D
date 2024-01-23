using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_2 : MonoBehaviour
{
    public GameObject Ball4;
    public AudioClip Pop;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball2") && collision.gameObject.GetComponent<Ball_2>() != null)
        {
            Vector3 ball2Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball4, ball2Position, Quaternion.identity);


            AudioSource.PlayClipAtPoint(Pop, transform.position);
        }
    }
}
