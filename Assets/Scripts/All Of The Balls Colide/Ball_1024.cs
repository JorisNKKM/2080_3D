using UnityEngine;

public class Ball_1024 : MonoBehaviour
{
    public GameObject Ball2048;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball1024") && collision.gameObject.GetComponent<Ball_1024>() != null)
        {
            Vector3 ball1024Position = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(Ball2048, ball1024Position, Quaternion.identity);
            Count2048 count2048 = FindObjectOfType<Count2048>();
            count2048.Start();
        }
        
    }
}
