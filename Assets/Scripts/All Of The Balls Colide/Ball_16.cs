using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_16 : MonoBehaviour
{
    public GameObject Ball32;
    public AudioClip Pop;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball16") && collision.gameObject.GetComponent<Ball_16>() != null)
        {
            Vector3 ball16Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball32, ball16Position, Quaternion.identity);

            AudioSource.PlayClipAtPoint(Pop, transform.position);
        }
    }
}
