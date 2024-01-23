using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_128 : MonoBehaviour
{
    public GameObject Ball256;
    public AudioClip Pop;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball128") && collision.gameObject.GetComponent<Ball_128>() != null)
        {
            Vector3 ball128Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball256, ball128Position, Quaternion.identity);

            AudioSource.PlayClipAtPoint(Pop, transform.position);
        }
    }
}
