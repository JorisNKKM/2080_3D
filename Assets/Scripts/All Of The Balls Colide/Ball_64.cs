// Ball_64 script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_64 : MonoBehaviour
{
    public GameObject Ball128;
    public AudioClip Pop;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball64") && collision.gameObject.GetComponent<Ball_64>() != null)
        {
            Vector3 ball64Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball128, ball64Position, Quaternion.identity);

            AudioSource.PlayClipAtPoint(Pop, transform.position);
        }
    }
}
