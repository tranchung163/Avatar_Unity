
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    //BallScript throwTheBall = new BallScript();
    //// Update is called once per frame
    //public void ThrowingBall()
    //{
    //    Debug.Log("Throwball");
    //    throwTheBall.ReleaseBall();
    //}
    public GameObject ballPrefab;
    public Transform throwPosition;
    public float throwForce = 10f;
    private Transform rightHand;
    public Rigidbody rb;

    void Start()
    {
        rightHand = GameObject.Find("mixamorig:RightHand").transform;
       
        ballPrefab.GetComponent<Transform>().parent = rightHand.parent;
        ballPrefab.GetComponent<Rigidbody>().useGravity = false;
    }

    void ReleaseBall()
    {
        Debug.Log("Release the ball");
        //GameObject ball = Instantiate(ballPrefab, throwPosition.position, Quaternion.identity);
        //Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        ballPrefab.GetComponent<Transform>().parent = null;
        rb = ballPrefab.GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.velocity = (ballPrefab.transform.forward * -throwForce);


        //ballRigidbody.AddForce(throwPosition.forward * throwForce, ForceMode.Impulse);
        //ballPrefab.GetComponent<Rigidbody>().AddForce(ballPrefab.GetComponent<Transform>().forward * throwForce);
        //GameObject ball = Instantiate(ballPrefab, throwPosition.position, Quaternion.identity);
        //Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        //ballRigidbody.AddForce(throwPosition.forward * throwForce, ForceMode.Impulse);
        //GameObject ball = Instantiate(ballPrefab, throwPosition.position, throwPosition.rotation);
        //Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        //ballRigidbody.AddForce(throwPosition.forward * throwForce, ForceMode.Impulse);
    }

    void catchBall()
    {
        Debug.Log("Catch the ball");
        rightHand = GameObject.Find("mixamorig:RightHandMiddle1").transform;
        ballPrefab.GetComponent<Rigidbody>().useGravity = false;
        ballPrefab.GetComponent<Transform>().parent = rightHand.parent;
        
        
    }
}
