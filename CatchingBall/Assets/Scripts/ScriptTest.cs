
using UnityEngine;

public class ScriptTest : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
