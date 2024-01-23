using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_8 : MonoBehaviour
{
    public GameObject Ball16;
    public AudioClip Pop;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball8") && collision.gameObject.GetComponent<Ball_8>() != null)
        {
            Vector3 ball8Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball16, ball8Position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(Pop, transform.position);
        }
    }
}
