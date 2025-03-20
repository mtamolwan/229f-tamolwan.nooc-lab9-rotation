using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }


    void FixedUpdate() //smoother than Update
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            //kick ball
            Kick();
        }
              
        //apply magnus effect
        ApplyMagnusEffect();

      
    }

    void Kick()
    {
        //staight kick
        rb.linearVelocity = velocity; 

        //rotate ball
        rb.angularVelocity = spin;
    }
    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);

        rb.AddForce( magnusForce );

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Goal"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
