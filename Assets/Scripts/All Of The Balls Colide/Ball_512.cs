using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_512 : MonoBehaviour
{
    public GameObject Ball1024;
    public AudioClip Pop;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball512") && collision.gameObject.GetComponent<Ball_512>() != null)
        {
            Vector3 ball512Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball1024, ball512Position, Quaternion.identity);

            AudioSource.PlayClipAtPoint(Pop, transform.position);
        }
    }
}
