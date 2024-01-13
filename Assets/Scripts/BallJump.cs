using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private bool isJumping = false;


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
        if (isJumping==true)
        {

            
            Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y + 0.01f, transform.position.z);
            transform.position = targetPosition;

            
        }
    }
}
