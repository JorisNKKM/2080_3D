using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private bool isJumping = false;
    public float jumpHeight;
    public float timeElapsed=0f;
    public float jumpInterval=2f;
    private void Start()
    {
        jumpHeight = 0.005f;
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("GameObject"))
        {
            if (!isJumping)
            {
                isJumping = true;
                
            }
        }
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= jumpInterval)
        {
            timeElapsed = 0f;
            jumpHeight += 0.0005f;
        }

        if (isJumping==true)
        { 
            Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y + jumpHeight, transform.position.z);
            transform.position = targetPosition;
        }
    }
}
