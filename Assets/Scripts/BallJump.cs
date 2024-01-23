using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private bool isJumping = false;
    public float jumpHeight;
    public float jumpStrenght;
    public float timeElapsed=0f;
    public float jumpInterval=0.5f;
    public void Start()
    {
        jumpHeight = 0.005f;
    }
    public void EasyDifficulty()
    {
        jumpStrenght = 0;
        print(1);
    }
    public void MediumDifficulty()
    {
        jumpStrenght = 0.005f;
    }
    public void HardDifficulty()
    {
        jumpStrenght = 0.01f;
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
            jumpHeight += jumpStrenght; 
            print(jumpHeight);
        }

        if (isJumping==true)
        { 
            Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y + jumpHeight, transform.position.z);
            transform.position = targetPosition;
        }
    }
}
