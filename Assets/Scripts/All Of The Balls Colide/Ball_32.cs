using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_32 : MonoBehaviour
{
    public GameObject Ball64;
    public AudioClip Pop;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball32") && collision.gameObject.GetComponent<Ball_32>() != null)
        {
            Vector3 ball32Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball64, ball32Position, Quaternion.identity);

            AudioSource.PlayClipAtPoint(Pop, transform.position);
        }
    }
}
