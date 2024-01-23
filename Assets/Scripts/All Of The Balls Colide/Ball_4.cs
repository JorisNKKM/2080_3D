using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_4 : MonoBehaviour
{
    public GameObject Ball8;
    public AudioClip Pop;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball4") && collision.gameObject.GetComponent<Ball_4>() != null)
        {
            Vector3 ball4Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball8, ball4Position, Quaternion.identity);

            AudioSource.PlayClipAtPoint(Pop, transform.position);
        }
    }
}
