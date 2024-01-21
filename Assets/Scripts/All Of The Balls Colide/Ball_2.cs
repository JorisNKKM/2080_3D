using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_2 : MonoBehaviour
{
    public GameObject Ball4;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball2") && collision.gameObject.GetComponent<Ball_2>() != null)
        {
            Vector3 ball2Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball4, ball2Position, Quaternion.identity);
        }
    }

}
