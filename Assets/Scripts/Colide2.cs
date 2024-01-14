using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colide2 : MonoBehaviour
{
    public GameObject Ball2;
    public GameObject Ball4;
    public GameObject Ball8;


    private void OnCollisionEnter(Collision collision)
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
    }

}
