using UnityEngine;

public class StageMovement : MonoBehaviour
{
    public GameObject Stage;
    public float speed = 5;
   
    

    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(speed * Time.deltaTime * Input.GetAxis("Vertical"), 0, -speed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
