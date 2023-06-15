using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody ballRigidbody;
    private Vector3 originalPosition;
    private bool isReturning = false;
    private Vector3 firstPosition = new Vector3(-1.36134f, 1.115441f, 0.2953635f);
   

    private void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        originalPosition = firstPosition;
    }

    private void Update()
    {
        if (isReturning)
        {
            MoveToStartPosition();
            
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        isReturning = true;
    }

    private void MoveToStartPosition()
    {
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("mixamorig:RightHandIndex1").transform.position, step);

        if (transform.position == GameObject.Find("mixamorig:RightHandIndex1").transform.position)
        {
            isReturning = false;
            ballRigidbody.velocity = Vector3.zero;
            ballRigidbody.angularVelocity = Vector3.zero;
        }
    }
}