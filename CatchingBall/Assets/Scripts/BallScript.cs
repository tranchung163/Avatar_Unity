
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Transform rightHand;
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rightHand = GameObject.Find("mixamorig:RightHand").transform;
        rb.useGravity = false;
        this.transform.parent = rightHand.parent;

    }
}
