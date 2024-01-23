using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_256 : MonoBehaviour
{
    public GameObject Ball512;
    public AudioClip Pop;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball256") && collision.gameObject.GetComponent<Ball_256>() != null)
        {
            Vector3 ball256Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball512, ball256Position, Quaternion.identity);

            AudioSource.PlayClipAtPoint(Pop, transform.position);
        }
    }
}
