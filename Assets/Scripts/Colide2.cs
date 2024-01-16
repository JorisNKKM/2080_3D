using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colide2 : MonoBehaviour
{
    public GameObject Ball2;
    public GameObject Ball4;
    public GameObject Ball8;
    public GameObject Ball16;
    public GameObject Ball32;
    public GameObject Ball64;
    public GameObject Ball128;
    public GameObject Ball256;
    public GameObject Ball512;
    public GameObject Ball1024;
    public GameObject Ball2048;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball2"))
        {
            Vector3 ball2Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball4, ball2Position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Ball4"))
        {
            Vector3 ball4Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball8, ball4Position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Ball8"))
        {
            Vector3 ball8Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball16, ball8Position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Ball16"))
        {
            Vector3 ball16Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball32, ball16Position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Ball32"))
        {
            Vector3 ball32Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball64, ball32Position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Ball64"))
        {
            Vector3 ball64Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball128, ball64Position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Ball128"))
        {
            Vector3 ball128Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball256, ball128Position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Ball256"))
        {
            Vector3 ball256Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball512, ball256Position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Ball512"))
        {
            Vector3 ball512Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball1024, ball512Position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Ball1024"))
        {
            Vector3 ball1024Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball2048, ball1024Position, Quaternion.identity);
        }
    }
}
