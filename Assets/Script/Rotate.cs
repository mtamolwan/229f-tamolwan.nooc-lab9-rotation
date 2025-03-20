using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV, torque; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //press left mouse 
        {
            rb.angularVelocity = angularV; 
        }
        else if (Input.GetMouseButtonDown(1)) //press right mouse
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKeyDown(KeyCode.F)) //Press F to stop
        {
            rb.angularVelocity = Vector3.zero; // (0,0,0)
        }
    }

}
